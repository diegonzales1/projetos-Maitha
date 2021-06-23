using Dominio.Entidades;
using Dominio.Interfaces;

namespace Repositorio.Repositorios
{
    class ContaRepositorio : BaseRepositorio<Conta>, IContaRepositorio
    {
        public ContaRepositorio(BancoContexto bancoContexto) : base(bancoContexto) { }
    }
}
