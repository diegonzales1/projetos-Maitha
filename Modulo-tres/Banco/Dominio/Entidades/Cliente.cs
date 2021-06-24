using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Cliente : Base
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPFCNPJ { get; set; }
        public virtual List<Contato> Contatos { get; set; }

    }
}
