using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Interfaces
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity itens);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity itens);
        void Deletar(TEntity item);
    }
}
