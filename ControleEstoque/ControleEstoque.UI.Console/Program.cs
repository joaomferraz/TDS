// See https://aka.ms/new-console-template for more information
using ConstroleEstoque.Persistencia.Colecao.Repositorio;
using ControleEstoque.Modelo.Basicas;

Console.WriteLine("Hello, World!");

var repositorioColecao = new RepositorioCRUDGenericoColecoes<CategoriaModelo>([]);
repositorioColecao.Adicionar(new CategoriaModelo(1, "Higiene", "sabonete"));
try
{
    repositorioColecao.Adicionar(new CategoriaModelo(2, "Higiene", "sabonete"));
    
}
catch (Exception e)
{
    
    Console.WriteLine(e.Message);
}

var categorias = repositorioColecao.ObterTodos();
foreach (var categoria in categorias)
{
    Console.Write(categoria);
}

//CategoriaModelo sabonete = new(1, "Higiene", "sabonete");

//CategoriaModelo sabonete1 = new(1, "Higiene", "sabonete");

//Console.Write(sabonete.Equals(sabonete1));
