using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Base
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
