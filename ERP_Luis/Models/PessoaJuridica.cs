using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ERP_JOSEREIS.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_JOSEREIS.Models
{
    public class PessoaJuridica : Pessoa
    {
        [Required(ErrorMessage = "O campo CNPJ é obrigatório")]
        [Range(14, 14, ErrorMessage = "O campo tem que ter 14 caracteres")]
        [Display(Name="CNPJ")]
        public String CNPJ { get; set; }
        
        [Required(ErrorMessage = "O campo Nome Fantasia é obrigatório")]
        [Range(3, 60, ErrorMessage = "O campo deve ter no minimo 3 e no maximo 60 caracteres")]
        [Display(Name="Nome Fantasia")]
        public String NomeFantasia { get; set; }

    }
}
