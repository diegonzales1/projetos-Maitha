using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiDoZeroAoUm.Models
{
    public class Pessoa
    {
       [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(30, ErrorMessage = "Este campo deve possuir no máximo 30 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve possuir no minimo 3 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(0, 99, ErrorMessage = "Entre com um numero valido")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(30, ErrorMessage = "Este campo deve possuir no maximo 20 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve possuir no minimo 3 caracteres")]
        public string Sexo { get; set; }
    }
}
