using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Dominio.Entidades
{
    public class Contato : Base
    {
        public int ClienteId { get; set; }
        public string TipoContato { get; set; }
        public string Telefone { get; set; }
        [JsonIgnore]

        public virtual Cliente Cliente{ get; set; }

    }
}
