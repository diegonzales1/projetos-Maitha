using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Agencia : Base
    {
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public virtual List<Conta> Contas { get; set; }
    }
}
