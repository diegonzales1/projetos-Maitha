using Dominio.Entidades;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Repositorios
{
    class ContatoRepositorio : BaseRepositorio<Contato>, IContatoRepositorio
    {
        public ContatoRepositorio(BancoContexto bancoContexto) : base(bancoContexto) { }
    }
}
