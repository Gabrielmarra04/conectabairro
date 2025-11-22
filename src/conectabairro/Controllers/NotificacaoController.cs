using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using conectabairro.Models;

namespace conectabairro.Controllers
{
    public class NotificacaoController : Controller
    {
        private readonly AppDbContext _context;

        public NotificacaoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Notificacao
        public async Task<IActionResult> Index()
        {
            var lista = await _context.Notifications
                .OrderByDescending(n => n.CreatedAt)
                .ToListAsync();

            return View(lista);
        }

        // ================================
        // 👇 NOVO: ACTION PARA O MODAL AJAX
        // ================================
        public async Task<IActionResult> IndexPartial()
        {
            var lista = await _context.Notifications
                .OrderByDescending(n => n.CreatedAt)
                .ToListAsync();

            return PartialView("_IndexPartial", lista);
        }


        // GET: Notificacao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var notificacao = await _context.Notifications
                .FirstOrDefaultAsync(n => n.Id == id);

            if (notificacao == null) return NotFound();

            return View(notificacao);
        }

        // GET: Notificacao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Notificacao/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,Message,IsRead,CreatedAt")] Notificacao notificacao)
        {
            if (ModelState.IsValid)
            {
                _context.Notifications.Add(notificacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(notificacao);
        }

        // GET: Notificacao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var notificacao = await _context.Notifications.FindAsync(id);
            if (notificacao == null) return NotFound();

            return View(notificacao);
        }

        // POST: Notificacao/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,Message,IsRead,CreatedAt")] Notificacao notificacao)
        {
            if (id != notificacao.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(notificacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NotificacaoExists(notificacao.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(notificacao);
        }

        // GET: Notificacao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var notificacao = await _context.Notifications
                .FirstOrDefaultAsync(n => n.Id == id);

            if (notificacao == null) return NotFound();

            return View(notificacao);
        }

        // POST: Notificacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var notificacao = await _context.Notifications.FindAsync(id);

            if (notificacao != null)
                _context.Notifications.Remove(notificacao);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NotificacaoExists(int id)
        {
            return _context.Notifications.Any(e => e.Id == id);
        }
    }
}
