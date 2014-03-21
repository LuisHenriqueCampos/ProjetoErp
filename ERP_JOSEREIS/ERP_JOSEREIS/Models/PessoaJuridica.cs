using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ERP_JOSEREIS.Models;

namespace ERP_JOSEREIS.Models
{
    public class PessoaJuridica : Pessoa
    {
        public String CNPJ { get; set; }

        public String NomeFantasia { get; set; }

    }
}