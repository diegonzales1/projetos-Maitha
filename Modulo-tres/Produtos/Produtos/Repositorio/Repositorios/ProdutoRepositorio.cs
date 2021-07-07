using Dominio.Interfaces;
using Repositorio.Contexto;

namespace Repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Dominio.Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(BancoContexto bancoContexto) : base(bancoContexto) { }
    }
}
