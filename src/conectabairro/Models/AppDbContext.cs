using Microsoft.EntityFrameworkCore;
using conectabairro.Models;
using System.Security.Cryptography; // Para o hash
using System.Text;
using BCrypt.Net; // Importe o BCrypt!

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
            // 1. DEFINIR CREDENCIAIS E GERAR HASH
            const string adminEmail = "admin@conectabairro.com";
            const string adminSenhaPlana = "Senha@123";

            // CORREÇÃO: Chamar o método HashPassword estático que definimos abaixo.
            string adminPasswordHash = HashPassword(adminSenhaPlana);
            // ==========================================================

            // 2. INSERIR O USUÁRIO ADMIN
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    UsuarioId = 1,
                    Nome = "Administrador Geral",
                    Email = adminEmail,
                    PasswordHash = adminPasswordHash, // AGORA COM O HASH DO BCrypt
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
        // Método estático para gerar o hash usando BCrypt
        private static string HashPassword(string password)
        {
            // Define o cost factor (custo/lentidão). 13 é um bom valor.
            return BCrypt.Net.BCrypt.HashPassword(password, workFactor: 13);
        }
    };


}
