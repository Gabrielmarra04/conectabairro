using conectabairro.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Hosting;
using System.IO;

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
        public async Task<IActionResult> CriarPost(Post post)
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
