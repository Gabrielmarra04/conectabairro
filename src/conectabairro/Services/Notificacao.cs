
using conectabairro.Models;
using Microsoft.EntityFrameworkCore;

namespace conectabairro.Services
{
    public class NotificacaoService
    {
        private readonly AppDbContext _context;

        public NotificacaoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateNotificationAsync(string userId, string message)
        {
            var notif = new Notificacao
            {
                UserId = userId,
                Message = message,
                IsRead = false,
                CreatedAt = DateTime.Now
            };

            _context.Notifications.Add(notif);   
            await _context.SaveChangesAsync();
        }

        public async Task<List<Notificacao>> GetUnreadAsync(string userId)
        {
            return await _context.Notifications   
                .Where(n => n.UserId == userId && !n.IsRead)
                .OrderByDescending(n => n.CreatedAt)
                .ToListAsync();
        }

        public async Task MarkAllAsRead(string userId)
        {
            var notifs = await _context.Notifications  
                .Where(n => n.UserId == userId && !n.IsRead)
                .ToListAsync();

            notifs.ForEach(n => n.IsRead = true);

            await _context.SaveChangesAsync();
        }
    }
}
