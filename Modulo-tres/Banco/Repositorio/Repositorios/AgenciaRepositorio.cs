using Dominio.Entidades;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Repositorios
{
    class AgenciaRepositorio : BaseRepositorio<Agencia>, IAgenciaRepositorio
    {
        public AgenciaRepositorio(BancoContexto bancoContexto) : base(bancoContexto) { }
    }
}
