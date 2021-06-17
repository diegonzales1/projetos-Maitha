using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBanco.Models
{
    public class ContaCorrente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public decimal Saldo { get; set; }

        public int TransacaoId { get; set; }

        public Transacao Transacao { get; set; }
    }
}
