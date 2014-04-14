using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.Models
{
    public class Funcionario : PessoaFisica
    {
        [Required(ErrorMessage="Data de Admissão Obrigatório")]
        public DateTime DataAdmissao { get; set; }
        
        public DateTime DataEmissao { get; set; }
        public decimal Salario { get; set; }
        
        public int IdDepartamento { get; set; }

        [ForeignKey("IdDepartamento")]
        public Departamento Departamento { get; set; }

        public int IdCargo { get; set; }

        [ForeignKey("IdCargo")]
        public Cargo Cargo { get; set; }
        
        public List<SalarioReajuste> SalarioReajustes { get; set; }
        public List<FuncionarioPagamento> FuncionariosPagamento { get; set; }
    }
}