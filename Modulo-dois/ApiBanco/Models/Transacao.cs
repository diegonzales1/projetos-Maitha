using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBanco.Models
{
    public class Transacao
    {
        [Key]
        public int Id { get; set; }

        public string Descricao { get; set; }

        public DateTime Data_Transicao {get; set;}

    }
}
