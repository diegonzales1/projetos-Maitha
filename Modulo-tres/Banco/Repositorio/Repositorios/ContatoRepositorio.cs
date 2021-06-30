using Dominio.Entidades;
using Dominio.Interfaces;
using Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Repositorios
{
    public class ContatoRepositorio : BaseRepositorio<Contato>, IContatoRepositorio
    {
        public  ContatoRepositorio(BancoContexto bancoContexto) : base(bancoContexto) {}

    }
}
