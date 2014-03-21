using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_JOSEREIS.Models
{
    public class PessoaFisica : Pessoa
    {
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string TelefoneCelular { get; set; }
        public string RG { get; set; }
    }
}