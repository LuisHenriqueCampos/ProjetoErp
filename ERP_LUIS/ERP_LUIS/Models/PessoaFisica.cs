using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.Models
{
    public class PessoaFisica : Pessoa
    {
        [Required(ErrorMessage="Data de Nascimento Obrigatória")]
        public DateTime DataNascimento { get; set; }
        
        [Required(ErrorMessage="CPF Obrigatório")]
        public string CPF { get; set; }
        
        [MaxLength(11)]
        public string TelefoneResidencial { get; set; }
        
        [MaxLength(20)]
        public string RG { get; set; }
    }
}