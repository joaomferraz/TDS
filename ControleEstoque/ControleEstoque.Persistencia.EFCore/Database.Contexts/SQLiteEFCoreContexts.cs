using System;
using ControleEstoque.Modelo.Basicas;
using Microsoft.EntityFrameworkCore;

namespace ControleEstoque.Persistencia.EFCore.Database.Contexts;

public class SQLiteEFCoreContexts : DbContext
{

    //public SQLiteEFCoreContexts(DbContextOptions<SQLiteEFCoreContexts> options) : DbContext(options)
        //{}

        public DbSet<CategoriaModelo> Categorias {get;set;}

        public string DbPath {get;}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source=utfpr.db");

}
