using Microsoft.EntityFrameworkCore;
using conectabairro.Models;
using System.Security.Cryptography; 
using System.Text;
using BCrypt.Net;

namespace conectabairro.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
            
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Posts> Posts { get; set; }

        public DbSet<Conversa> Conversas { get; set; }

        public DbSet<Mensagem> Mensagens { get; set; }

        public DbSet<Comentario> Comentarios { get; set; }

        public DbSet<Reacao> Reacoes { get; set; }

        public DbSet<Notificacao> Notifications { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ==========================================================
            const string adminEmail = "admin@a";
            const string adminSenhaPlana = "Senha123";


            string adminPasswordHash = HashPassword(adminSenhaPlana);
            // ==========================================================

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    UsuarioId = 1,
                    Nome = "Administrador Geral",
                    Email = adminEmail,
                    PasswordHash = adminPasswordHash, 
                    TipoUsuarios = TipoUsuario.Admin,
                    Telefone = "",
                    Rua = "N/A",
                    Bairro = "N/A",
                    Cidade = "N/A",
                    Estado = "N/A",
                    Cnpj = null,
                    RazaoSocial = null
                }
            );

            // Relacionamento na tabela Conversa (para AutorPost e Interessado)
            modelBuilder.Entity<Conversa>()
                .HasOne(c => c.AutorPost)
                .WithMany(u => u.ConversasIniciadas) 
                .HasForeignKey(c => c.AutorPostId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Conversa>()
                .HasOne(c => c.Interessado)
                .WithMany() 
                .HasForeignKey(c => c.InteressadoUsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            // Chave Única para Conversa (para evitar chats duplicados para o mesmo Post/Usuários)
            modelBuilder.Entity<Conversa>()
                .HasIndex(c => new { c.PostId, c.AutorPostId, c.InteressadoUsuarioId })
                .IsUnique();

            // Relacionamento na tabela Mensagem (Remetente)
            modelBuilder.Entity<Mensagem>()
                .HasOne(m => m.Remetente)
                .WithMany(u => u.MensagensEnviadas)
                .HasForeignKey(m => m.RemetenteUsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento Post 
            modelBuilder.Entity<Posts>()
                .HasMany(p => p.Comentarios) 
                .WithOne(c => c.Post)        
                .HasForeignKey(c => c.PostId)
                .OnDelete(DeleteBehavior.Cascade); 

            // Relacionamento Usuario 
            modelBuilder.Entity<Posts>()
                .HasOne(p => p.Usuario)
                .WithMany(u => u.PostsCriados)
                .HasForeignKey(p => p.AutorId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento Usuario 
            modelBuilder.Entity<Comentario>()
                .HasOne(c => c.Autor)
                .WithMany(u => u.ComentariosFeitos)
                .HasForeignKey(c => c.AutorUsuarioId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Reacao>()
                .HasIndex(r => new { r.PostId, r.AutorUsuarioId })
                .IsUnique();
        }
        private static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, workFactor: 13);
        }
    };


}
