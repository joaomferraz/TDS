using System;
using ControleEstoque.Modelo.Intefaces.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace ConstroleEstoque.Persistencia.EFCore.Repositorios;

public class RepositorioCRUDGenericoEFCore<T>(DbContext repositorio) : IRepositorioCRUDGenerico<T> where T : class
{
    public void Adicionar(T entidade)
    {
        throw new NotImplementedException();
    }

    public void Atualizar(T entidade)
    {
        throw new NotImplementedException();
    }

    public T? ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> ObterTodos()
    {
        throw new NotImplementedException();
    }

    public void Remover(T entidade)
    {
        throw new NotImplementedException();
    }
}
