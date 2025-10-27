using conectabairro.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using System.Security.Claims;

namespace conectabairro.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public HomeController(ILogger<HomeController> logger, AppDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _logger = logger;
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        public async Task<IActionResult> Index(string termoBusca, string categoria)
        {
            
            var query = _context.Posts.AsQueryable(); // 1. Inicia a consulta


            if (!string.IsNullOrEmpty(termoBusca)) // 2. Filtro de pesquisa de texto
            {
                query = query.Where(p => p.Titulo.Contains(termoBusca) ||
                                         p.Descricao.Contains(termoBusca));
            }

            if (!string.IsNullOrEmpty(categoria)) //3. Filtro por categoria
            {

                if (Enum.TryParse<Categoria>(categoria, out Categoria categoriaEnum))
                {
                    query = query.Where(p => p.Categoria == categoriaEnum);
                }
                else
                {
                    // Se a string for inválida
                    _logger.LogWarning($"Categoria de filtro inválida recebida: {categoria}");
                }
            }

            var postsFiltrados = await query.OrderByDescending(p => p.DataCriacao).ToListAsync();

            ViewData["TermoBusca"] = termoBusca;
            ViewData["Categoria"] = categoria;

            return View(postsFiltrados);
      
        }

        public IActionResult CriarPost()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CriarPost(Posts post)
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            if (userIdClaim != null && int.TryParse(userIdClaim.Value, out int autorId))
            {
                post.AutorId = autorId;
            }
            else
            {
                ModelState.AddModelError("", "Não foi possível identificar o usuário logado.");
                return View(post);
            }

            await CriarCaminhoImagem(post);

            ModelState.Remove(nameof(post.ImagemArquivo));

            if (ModelState.IsValid)
            {
                post.DataCriacao = DateTime.Now;
                _context.Add(post);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(post);
        }

        private async Task CriarCaminhoImagem(Posts post)
        {
            if (post.ImagemArquivo != null)
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string uploadsFolder = Path.Combine(wwwRootPath, "imagens", "posts");
                Directory.CreateDirectory(uploadsFolder);

                string fileName = Guid.NewGuid().ToString();
                string extension = Path.GetExtension(post.ImagemArquivo.FileName);
                string filePath = Path.Combine(uploadsFolder, fileName + extension);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await post.ImagemArquivo.CopyToAsync(fileStream);
                }

                post.CaminhoImagem = Path.Combine("/imagens/posts", fileName + extension).Replace("\\", "/");
            }
        }

        [HttpGet] 
        public async Task<IActionResult> DeletarPost(int id)
        {
            var post = await _context.Posts.FindAsync(id);

            if (post == null)
            {
                return NotFound();
            }

            
            if (!string.IsNullOrEmpty(post.CaminhoImagem))
            {
                
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string imagePath = Path.Combine(wwwRootPath, post.CaminhoImagem.TrimStart('/'));

                if (System.IO.File.Exists(imagePath))
                {
                   
                    try
                    {
                        System.IO.File.Delete(imagePath);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, $"Erro ao deletar a imagem do post ID {id}.");
                        
                    }
                }
            }

            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> DetalharPost(int id)
        {
            var post = await _context.Posts
                .Include(p => p.Usuario)
                .Include(p => p.Reacoes)
                .Include(p => p.Comentarios)
                    .ThenInclude(c => c.Autor)
                .FirstOrDefaultAsync(p => p.PostId == id);

            if (post == null)
            {
                return NotFound();
            }

            post.UsuarioLogado = await ObterUsuarioLogado(post);

            return View(nameof(DetalharPost), post);
        }

        private async Task<Usuario> ObterUsuarioLogado(Posts post)
        {
            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier); //guarda informações do usuário logado

            var usuarioId = int.Parse(userIdClaim.Value); //Pega o valor do id do usuário logado

            return await _context.Usuarios.FindAsync(usuarioId);
        }

        [HttpGet]
        public async Task<IActionResult> EditarPost(int id)
        {
            var post = await _context.Posts.FindAsync(id);

            if (post == null)
            {
                return NotFound();
            }

            return View(nameof(EditarPost), post);
        }

        [HttpPost]
        public async Task<IActionResult> EditarPost(Posts post)
        {
            await CriarCaminhoImagem(post);

            _context.Posts.Update(post);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(DetalharPost), new { id = post.PostId });
        }

        [HttpPost]
        public async Task<IActionResult> CriarComentario(Comentario comentario)
        {
            _context.Comentarios.Add(comentario);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(DetalharPost), new { id = comentario.PostId });
        }

        [HttpPost]
        public async Task<IActionResult> DeletarComentario(int id)
        {
            var comentario = await _context.Comentarios.FindAsync(id);

            if (comentario == null)
            {
                return NotFound();
            }

            _context.Comentarios.Remove(comentario);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(DetalharPost), new { id = comentario.PostId });
        }

        [HttpPost]
        public async Task<IActionResult> GravarLike([FromForm] int postId, [FromForm] TipoReacao tipoReacao)
        {
            var post = await _context.Posts.FindAsync(postId);

            if (post == null)
            {
                return NotFound();
            }

            post.UsuarioLogado = await ObterUsuarioLogado(post);

            var reacaoExistente = await _context.Reacoes
                .FirstOrDefaultAsync(x => x.PostId == postId && x.AutorUsuarioId == post.UsuarioLogado.UsuarioId);

            if (reacaoExistente == null)
            {
                var novaReacao = new Reacao
                {
                    PostId = postId,
                    AutorUsuarioId = post.UsuarioLogado.UsuarioId,
                    TipoReacao = tipoReacao
                };

                _context.Reacoes.Add(novaReacao);
            }
            else if(reacaoExistente.TipoReacao == tipoReacao)
            {
                _context.Reacoes.Remove(reacaoExistente);
            }
            else
            {
                reacaoExistente.TipoReacao = tipoReacao;
                _context.Reacoes.Update(reacaoExistente);
            }
     
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(DetalharPost), new { id = post.PostId });
        }

        //O chat ainda está pendente de criação
        //public Conversa Conversa { get; set; }

        //[BindProperty]
        //public Mensagem MensagemInput { get; set; }
        //[HttpGet]
        //public async Task<IActionResult> ChatPost(int id)
        //{
        //    Conversa = await _context.Conversas
        //        .Include(p => p.Post)
        //        .FirstOrDefaultAsync(p => p.PostId == id);

        //    if (Conversa == null)
        //    {
        //        return NotFound();
        //    }

        //    MensagemInput = new Mensagem { PostId = id };

        //    return View(nameof(ChatPost));
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        
        }
    }
}
