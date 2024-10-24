using System;

namespace ControleEstoque.Modelo.Intefaces.Repositorios;

public interface IRepositorioCRUDGenericoEF<T> where T : class
    {

        void Adicionar(object tabela, T entidade);

        IEnumerable<T> ObterTodos(object tabela);

        T? ObterPorId(int id);

        void Atualizar(T entidade);

        void Remover(T entidade);
    }

