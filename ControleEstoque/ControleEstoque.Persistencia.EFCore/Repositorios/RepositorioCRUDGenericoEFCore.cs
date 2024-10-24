using System;
using ControleEstoque.Modelo.Intefaces.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace ConstroleEstoque.Persistencia.EFCore.Repositorios;

public class RepositorioCRUDGenericoEFCore<T>(DbContext repositorio) : IRepositorioCRUDGenericoEF<T> where T : class
{
    public void Adicionar(object tabela, T entidade)
    {
        (tabela as DbSet<T>)!.Add(entidade);
        repositorio.SaveChangesAsync();
    }

    public void Atualizar(T entidade)
    {
        throw new NotImplementedException();
    }

    public T? ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> ObterTodos(object tabela)
    {
        DbSet<T>? dbsetTabela = tabela as DbSet<T>;
        return dbsetTabela!.ToList();
    }

    public void Remover(T entidade)
    {
        throw new NotImplementedException();
    }
}
