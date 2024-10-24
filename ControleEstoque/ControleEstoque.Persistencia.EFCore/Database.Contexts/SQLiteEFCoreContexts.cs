using System;
using System.Reflection.Emit;
using ControleEstoque.Modelo.Basicas;
using Microsoft.EntityFrameworkCore;

namespace ControleEstoque.Persistencia.EFCore.Database.Contexts;

public class SQLiteEFCoreContexts : DbContext
{

    //public SQLiteEFCoreContexts(DbContextOptions<SQLiteEFCoreContexts> options) : DbContext(options)
        //{}

        public DbSet<CategoriaModelo> Categorias {get;set;}

        // public string DbPath {get;}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($@"Data Source=C:\Users\jmach\OneDrive\Documents\UTFPR\6 semestre\CC56C TECNOLOGIA EM DESENVOLVIMENTO DE SISTEMAS\TDS\ControleEstoque\ControleEstoque.Persistencia.EFCore\utfpr.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder
        .Entity<CategoriaModelo>(
            eb => {
                eb.HasKey(pk => pk.CategoriaID);
            });
    }

}
