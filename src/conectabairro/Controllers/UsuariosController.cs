using conectabairro.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;


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
                // Adiciona o erro ao ModelState. A chave deve ser o nome da propriedade ("Email").
                ModelState.AddModelError("Email", "Este e-mail já está cadastrado no sistema.");
            }

            if (ModelState.IsValid)
            {

                usuario.PasswordHash = BCrypt.Net.BCrypt.HashPassword(usuario.PasswordHash);

                _context.Add(usuario);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            // Se houver erro de validação (incluindo o e-mail duplicado), retorna a View
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
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UsuarioId,Nome,Email,PasswordHash,Telefone,Rua,Bairro,Cidade,Estado,TipoUsuarios,Cnpj,RazaoSocial")] Usuario usuario)
        {
            if (id != usuario.UsuarioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    usuario.PasswordHash = BCrypt.Net.BCrypt.HashPassword(usuario.PasswordHash);
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.UsuarioId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
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
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.UsuarioId == id);
        }
    }
}
