using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ControleEstoque.EFCore.DataContext
{
    public class ControleEstoqueEFCoreContextFactory : IDesignTimeDbContextFactory<ControleEstoqueEFCoreContext>
    {
        public ControleEstoqueEFCoreContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ControleEstoqueEFCoreContext>();

            // Carregar a configuração do appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(),
                             "../ControleEstoque.WebAPI"))
                .AddJsonFile("appsettings.json")
                .Build();

            // Configurar a string de conexão
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlite(connectionString);

            return new ControleEstoqueEFCoreContext(optionsBuilder.Options);
        }
    }
}
