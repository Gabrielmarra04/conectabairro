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

        public DbSet<Post> Posts { get; set; }

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
        }
        private static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, workFactor: 13);
        }
    };


}
