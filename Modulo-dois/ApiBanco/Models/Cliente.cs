using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBanco.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(80, ErrorMessage = "Este campo deve possuir no maximo 80 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve possuir no minimo 3 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public String Data_Nascimento { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Telefone { get; set; }

        public int ContaCorrenteId { get; set; }

        public ContaCorrente ContaCorrente { get; set; }


    }
}
