using conectabairro.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Claims;
using System.Security.Cryptography;

namespace conectabairro.Controllers
{

    public class UsuariosController : Controller
    {
        private readonly AppDbContext _context;

        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }


        [Authorize(Policy = "RequerAdmin")]
        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Usuarios.ToListAsync());
        }

        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(Usuario usuario)
        {
            var dados = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Email == usuario.Email);

            if (dados == null)
            {
                ViewBag.Mensagem = "Email e/ou senha inválidos!";
                return View();
            }

            bool senhaOk = BCrypt.Net.BCrypt.Verify(usuario.PasswordHash, dados.PasswordHash);

            if (senhaOk)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, dados.Email),
                    new Claim(ClaimTypes.Name, dados.Nome),
                    new Claim(ClaimTypes.NameIdentifier, dados.UsuarioId.ToString()),
                    new Claim("TipoUsuario", dados.TipoUsuarios.ToString())
                };

                var usuarioIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(usuarioIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(3),
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(principal, props);

                return Redirect("/");
            }
            else
            {
                ViewBag.Mensagem = "Email e/ou senha inválidos!";
            }


            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Login", "Usuarios");

        }


        // Tela Meus Dados


[Authorize]
public async Task<IActionResult> MeusDados()
{

    var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier); //guarda informações do usuário logado

    if (userIdClaim == null)//Se não encontrar o id do usuário
    {
        return RedirectToAction("Login"); //Redireciona para a tela de login
    }

        var usuarioId = int.Parse(userIdClaim.Value); //Pega o valor do id do usuário logado

        var usuario = await _context.Usuarios.FindAsync(usuarioId); //Busca o usuário no banco de dados

    if (usuario == null)
    {
        return NotFound();//Se o usuário não for encontrado retorna erro "Não Encontrado)
    }

        return View(usuario); //Se o usuário for encontrado retorna a View com os dados do usuário.

        }



// ----------- ESQUECI MINHA SENHA -------------
[AllowAnonymous]
        public IActionResult EsqueciSenha()
        {
            return View();
        }

        
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> EsqueciSenha(string email, [FromServices] EmailService emailService)
        {
            if (string.IsNullOrEmpty(email))
            {
                TempData["Erro"] = "Por favor, informe um e-mail válido.";
                return RedirectToAction("EsqueciSenha");
            }

            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == email);
            if (usuario == null)
            {
                TempData["Erro"] = "E-mail não encontrado!";
                return RedirectToAction("EsqueciSenha");
            }

            var token = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64));
            usuario.ResetToken = token;
            usuario.ResetTokenExpiry = DateTime.UtcNow.AddHours(1);

            await _context.SaveChangesAsync();

            var link = Url.Action("RedefinirSenha", "Usuarios", new { token = token }, Request.Scheme);


            var mensagem = $@"
        <h3>Redefinição de senha - ConectaBairro</h3>
        <p>Olá {usuario.Nome},</p>
        <p>Clique no link abaixo para redefinir sua senha:</p>
        <p><a href='{link}'>Redefinir Senha</a></p>
        <p>Esse link é válido por 1 hora.</p>";

            try
            {
                await emailService.EnviarEmailAsync(usuario.Email, "Redefinição de Senha", mensagem);
                TempData["Sucesso"] = "Um link de redefinição foi enviado para o seu e-mail.";
            }
            catch (Exception)
            {
                TempData["Erro"] = "Ocorreu um erro ao enviar o e-mail. Verifique as configurações SMTP.";
            }

            return RedirectToAction("EsqueciSenha");
        }



        // ----------- REDEFINIR SENHA -------------
        [AllowAnonymous]
        public async Task<IActionResult> RedefinirSenha(string token)
        {
            if (string.IsNullOrEmpty(token))
                return BadRequest("Token inválido");

            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.ResetToken == token && u.ResetTokenExpiry > DateTime.UtcNow);
            if (usuario == null)
                return BadRequest("Token expirado ou inválido");

            ViewBag.Token = token;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> RedefinirSenha(string token, string novaSenha)
        {
            if (string.IsNullOrEmpty(token) || string.IsNullOrEmpty(novaSenha))
            {
                TempData["Erro"] = "Token inválido ou senha não informada.";
                return View();
            }

            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.ResetToken == token);

            if (usuario == null || usuario.ResetTokenExpiry < DateTime.UtcNow)
            {
                TempData["Erro"] = "Token inválido ou expirado.";
                return View();
            }

            usuario.PasswordHash = BCrypt.Net.BCrypt.HashPassword(novaSenha); 
            usuario.ResetToken = null;
            usuario.ResetTokenExpiry = null;

            await _context.SaveChangesAsync();


            TempData["Sucesso"] = "Senha redefinida com sucesso! Você já pode fazer login novamente.";

            return View(); 
        }


        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.UsuarioId == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UsuarioId,Nome,Email,PasswordHash,Telefone,Rua,Bairro,Cidade,Estado,TipoUsuarios,Cnpj,RazaoSocial")] Usuario usuario)
        {
            var emailExistente = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Email == usuario.Email);

            if (emailExistente != null)
            {
                ModelState.AddModelError("Email", "Este e-mail já está cadastrado no sistema.");
            }

            if (ModelState.IsValid)
            {

                usuario.PasswordHash = BCrypt.Net.BCrypt.HashPassword(usuario.PasswordHash);

                _context.Add(usuario);
                await _context.SaveChangesAsync();

                TempData["MensagemSucesso"] = "Cadastro realizado com sucesso! Faça seu login abaixo.";

                return RedirectToAction("Login", "Usuarios");
            }

            return View(usuario);

        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            ViewBag.ReturnUrl = Request.Headers["Referer"].ToString(); //captura a URL anterior

            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UsuarioId,Nome,Email,Telefone,Rua,Bairro,Cidade,Estado,TipoUsuarios,Cnpj,RazaoSocial")] Usuario usuario, string NovaSenha)
        {
            if (id != usuario.UsuarioId)
                return NotFound();

            ModelState.Remove("PasswordHash");

            if (!ModelState.IsValid)
                return View(usuario);

            try
            {
                var usuarioExistente = await _context.Usuarios.FindAsync(id);
                if (usuarioExistente == null)
                    return NotFound();

                usuarioExistente.Nome = usuario.Nome;
                usuarioExistente.Email = usuario.Email;
                usuarioExistente.Telefone = usuario.Telefone;
                usuarioExistente.Rua = usuario.Rua;
                usuarioExistente.Bairro = usuario.Bairro;
                usuarioExistente.Cidade = usuario.Cidade;
                usuarioExistente.Estado = usuario.Estado;
                usuarioExistente.Cnpj = usuario.Cnpj;
                usuarioExistente.RazaoSocial = usuario.RazaoSocial;

                if (!string.IsNullOrWhiteSpace(NovaSenha))
                {
                    usuarioExistente.PasswordHash = BCrypt.Net.BCrypt.HashPassword(NovaSenha);
                }

                await _context.SaveChangesAsync();

                if (User.HasClaim("TipoUsuario", "Admin")) // Verifica se o usuário logado é um Administrador
                {
                    TempData["MensagemSucesso"] = "Usuário atualizado com sucesso!"; 
                    return RedirectToAction("Index", "Usuarios"); // Se for administrador direciona para a área administrativa (lista de usuários)
                }
                else
                {
                    TempData["MensagemSucesso"] = "Seus dados foram atualizados com sucesso!"; 
                    return RedirectToAction("Index", "Home"); //Se for qualquer outro tipo de usuário, retorna para o feed.
                } 


                TempData["MensagemSucesso"] = "Usuário atualizado com sucesso!";

                return RedirectToAction("Index", "Usuarios");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Erro ao atualizar o usuário: " + ex.Message);
                return View(usuario);
            }
            
        }

        // GET: Usuarios/Delete/5
        [Authorize(Policy = "RequerAdmin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.UsuarioId == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "RequerAdmin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
            }

            await _context.SaveChangesAsync();
            TempData["MensagemDelete"] = "Usuário Excluído com sucesso!";
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.UsuarioId == id);
        }

        [HttpGet]
        public async Task<IActionResult> Index(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;

            var usuarios = from u in _context.Usuarios
                           select u;

            if (!String.IsNullOrEmpty(searchString))
            {
                usuarios = usuarios.Where(u => u.Nome.Contains(searchString)
                                            || u.Bairro.Contains(searchString)); 
            }

            return View(await usuarios.ToListAsync());
        }

    }
}
