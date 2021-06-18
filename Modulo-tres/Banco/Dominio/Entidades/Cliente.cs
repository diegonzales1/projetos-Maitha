using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string email { get; set; }
        public int CPFCNPJ { get; set; }
        public virtual List<Contato> Contatos { get; set; }
    }
}
