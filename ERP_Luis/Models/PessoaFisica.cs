using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ERP_JOSEREIS.Models
{
    public class PessoaFisica : Pessoa
    {
        
        [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório")]
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]        
        public DateTime DataNascimento { get; set; }

        
        [Required(ErrorMessage = "O campo CNPJ é obrigatório")]
        [Display(Name = "CPF")]
        [Range(11, 11, ErrorMessage = "O campo deve ter 11 caracteres")]
        public string CPF { get; set; }

        [Display(Name = "Telefone Residencial")]        
        [Range(11, 11, ErrorMessage = "O campo deve ter 11 caracteres")]
        public string TelefoneResidencial { get; set; }

        [Display(Name = "RG")]
        [Range(5,20, ErrorMessage="O campo deve ter no minimo 5 e no maximo 20 caracteres")]
        public string RG { get; set; }

    }
}