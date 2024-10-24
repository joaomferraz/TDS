using ControleEstoque.Modelo.Basicas;
using Microsoft.EntityFrameworkCore;

namespace ControleEstoque.EFCore.DataContext;

public class ControleEstoqueEFCoreContext : DbContext
{
    public ControleEstoqueEFCoreContext(DbContextOptions<ControleEstoqueEFCoreContext> options) : base(options)
    {
        
    }
    
    public DbSet<PositionTitle> PositionsTitle { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source=./utfpr.db");


}
