// A ponte entre entre o código C# e o banco de dados.


using Microsoft.EntityFrameworkCore;
using BibliotecaFreeCAD.Models;

namespace BibliotecaFreeCAD.Data
{
    public class AppDbContext : DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) // Construtor que recebe as opções de configuração do DbContext
        {

        }

          public DbSet<Peca> Pecas { get; set; } // Representa a tabela de peças no banco de dados
    }
}
