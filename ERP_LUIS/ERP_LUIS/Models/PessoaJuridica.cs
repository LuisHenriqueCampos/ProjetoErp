using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.Models
{
    public class PessoaJuridica : Pessoa
    {
        [Required(ErrorMessage="CNPJ Obrigatório")]
        public string CNPJ { get; set; }
        
        [Required(ErrorMessage="Nome Fantasia Obrigatório")]
        public string NomeFantasia { get; set; }
    }
}