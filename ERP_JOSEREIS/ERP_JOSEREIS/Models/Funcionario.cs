using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ERP_JOSEREIS.Models
{
    public class Funcionario : PessoaFisica
    {
        public DateTime DataAdmissao { get; set; }
        public DateTime DataDemissao { get; set; }
        public float Salario { get; set; }
        public Departamento Departamento{ get; set; }
        public Cargo IdCargo { get; set; }
        public ICollection<FuncionarioPagamento> FuncionarioPagamentos { get; set; }

    }
}