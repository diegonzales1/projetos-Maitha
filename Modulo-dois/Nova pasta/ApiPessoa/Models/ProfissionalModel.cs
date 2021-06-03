using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPessoa.Models
{
    public class ProfissionalModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(30, ErrorMessage = "Este campo deve possuir no máximo 30 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve possuir no minimo 3 caracteres")]
        public string Funcao { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int Numero_carteira { get; set; }

    }
}
