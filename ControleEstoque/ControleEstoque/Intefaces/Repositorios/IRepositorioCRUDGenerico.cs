using System;

namespace ControleEstoque.Modelo.Intefaces.Repositorios;

public interface IRepositorioCRUDGenerico<T> where T : class
    {

        void Adicionar(T entidade);

        IEnumerable<T> ObterTodos();

        T? ObterPorId(int id);

        void Atualizar(T entidade);

        void Remover(T entidade);
    }

