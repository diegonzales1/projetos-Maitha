using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiDoZeroAoUm.Models
{
    public class Profissional
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(50, ErrorMessage = "Este campo deve possuir no máximo 30 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve possuir no minimo 3 caracteres")]
        public string Funcao { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(0, 9999999, ErrorMessage = "Entre com um número valido")]
        public int Num_Carteira { get; set; }

        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
