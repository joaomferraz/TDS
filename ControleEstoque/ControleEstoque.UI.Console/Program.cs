using ConstroleEstoque.Persistencia.EFCore.Repositorios;
using ControleEstoque.Modelo.Basicas;
using ControleEstoque.Persistencia.EFCore.Database.Contexts;

var efDbcontext = new SQLiteEFCoreContexts();
var repositorioEF = new RepositorioCRUDGenericoEFCore<CategoryModel>(efDbcontext);
repositorioEF.Adicionar(efDbcontext.Categorias, new CategoryModel(1, "Higiene", "sabonete"));

foreach (var categoria in repositorioEF.ObterTodos(efDbcontext.Categorias))
{
    Console.Write(categoria);
}

// Console.WriteLine("Hello, World!");

// var repositorioColecao = new RepositorioCRUDGenericoColecoes<CategoriaModelo>([]);
// repositorioColecao.Adicionar(new CategoriaModelo(1, "Higiene", "sabonete"));
// try
// {
//     repositorioColecao.Adicionar(new CategoriaModelo(2, "Higiene", "sabonete"));
    
// }
// catch (Exception e)
// {
    
//     Console.WriteLine(e.Message);
// }

// var categorias = repositorioColecao.ObterTodos();
// foreach (var categoria in categorias)
// {
//     Console.Write(categoria);
// }

//CategoriaModelo sabonete = new(1, "Higiene", "sabonete");

//CategoriaModelo sabonete1 = new(1, "Higiene", "sabonete");

//Console.Write(sabonete.Equals(sabonete1));
