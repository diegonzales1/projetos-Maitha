using Dominio.Interfaces;
using Repositorio.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly BancoContexto BancoContexto;

        public BaseRepositorio(BancoContexto bancoContexto)
        {
            BancoContexto = bancoContexto;
        }

        public void Adicionar(TEntity itens)
        {
            BancoContexto.Set<TEntity>().Add(itens);
            BancoContexto.SaveChanges();
        }

        public void Atualizar(TEntity itens)
        {
            BancoContexto.Set<TEntity>().Update(itens);
            BancoContexto.SaveChanges();
        }

        public void Deletar(TEntity item)
        {
            BancoContexto.Set<TEntity>().Remove(item);
            BancoContexto.SaveChanges();
        }

        public void Dispose()
        {
            BancoContexto.Dispose();
        }

        public TEntity ObterPorId(int id)
        {
            return BancoContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return BancoContexto.Set<TEntity>().ToList();
        }
    }
}
