using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using conectabairro.Models;
using System.Security.Claims;

namespace conectabairro.Controllers
{
    public class ReacaoController : Controller
    {
        private readonly AppDbContext _context;

        public ReacaoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Curtir(int postId)
        {
            var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userIdString == null)
                return Unauthorized();

            int userId = int.Parse(userIdString);

            // SALVA A REAÇÃO
            var reacao = new Reacao
            {
                AutorUsuarioId = userId,
                PostId = postId,
                TipoReacao = TipoReacao.Like
            };

            _context.Reacoes.Add(reacao);

            // BUSCA O POST
            var post = await _context.Posts
                .FirstOrDefaultAsync(p => p.PostId == postId);

            if (post != null && post.AutorId != userId)
            {
                // CRIA NOTIFICAÇÃO
                var notificacao = new Notificacao
                {
                    UserId = post.AutorId.ToString(), 
                    Message = "Seu post recebeu uma curtida!",
                    IsRead = false,
                    CreatedAt = DateTime.Now
                };

                _context.Notifications.Add(notificacao);
            }

            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
