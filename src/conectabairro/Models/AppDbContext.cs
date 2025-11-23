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

        public DbSet<SolicitacaoEdicao> SolicitacoesEdicao { get; set; }

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
                .WithMany(u => u.ConversasIniciadas) // Uma conversa tem 1 AutorPost. Um Usuario pode ser AutorPost em N conversas.
                .HasForeignKey(c => c.AutorPostId)
                .OnDelete(DeleteBehavior.Restrict); // Evita exclusão em cascata se o usuário for excluído.

            modelBuilder.Entity<Conversa>()
                .HasOne(c => c.Interessado)
                .WithMany() // Se você não quiser uma coleção no model Usuario para Conversas como Interessado
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

            // Relacionamento Post -> Comentarios (1 para N)
            modelBuilder.Entity<Posts>()
                .HasMany(p => p.Comentarios) // Um Post tem muitos Comentários
                .WithOne(c => c.Post)        // Um Comentário pertence a um Post
                .HasForeignKey(c => c.PostId)
                .OnDelete(DeleteBehavior.Cascade); // Se o Post for excluído, os comentários também são.

            // Relacionamento Post -> Conversas (1 para N)
            modelBuilder.Entity<Posts>()
                .HasMany(p => p.Conversas) // Um Post tem muitas Conversas
                .WithOne(c => c.Post)        // Uma Conversa pertence a um Post
                .HasForeignKey(c => c.PostId)
                .OnDelete(DeleteBehavior.Cascade); // Se o Post for excluído, as conversas também são.

            // Relacionamento Usuario -> Post (1 para N)
            modelBuilder.Entity<Posts>()
                .HasOne(p => p.Usuario)
                .WithMany(u => u.PostsCriados)
                .HasForeignKey(p => p.AutorId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento Usuario -> Comentario (1 para N)
            modelBuilder.Entity<Comentario>()
                .HasOne(c => c.Autor)
                .WithMany(u => u.ComentariosFeitos)
                .HasForeignKey(c => c.AutorUsuarioId)
                .OnDelete(DeleteBehavior.Restrict); // Não exclui o usuário se um comentário for deletado.

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
