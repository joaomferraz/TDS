using ControleEstoque.Model.Model;
using Microsoft.EntityFrameworkCore;

namespace ControleEstoque.EFCore.DataContext;

public class ControleEstoqueEFCoreContext : DbContext
{
    public ControleEstoqueEFCoreContext(DbContextOptions<ControleEstoqueEFCoreContext> options) : base(options)
    {
    }
    
    public DbSet<CategoryModel> Categories { get; set; }
    public DbSet<Person> Persons { get; set; } 

    public DbSet<Product> Products { get; set; }

    public DbSet<Supplier> Suppliers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=C:\\Users\\jmach\\OneDrive\\Documents\\UTFPR\\TDS\\ControleEstoque\\ControleEstoque.EFCore\\utfpr.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<CategoryModel>(eb =>
        {
            eb.HasKey(pk => pk.CategoryID);
        });

        modelBuilder.Entity<Person>(eb =>
        {
            eb.HasKey(pk => pk.PersonID);
        });

        modelBuilder.Entity<Product>(eb =>
        {
            eb.HasKey(pk => pk.ProductID);
        });

        modelBuilder.Entity<Supplier>(eb =>
        {
            eb.HasKey(pk => pk.SupplierID);
        });
    }
}
