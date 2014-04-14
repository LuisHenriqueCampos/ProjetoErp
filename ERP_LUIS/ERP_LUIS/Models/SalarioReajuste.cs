using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.Models
{
    public class SalarioReajuste
    {
        [Key]
        public int IdSalarioReajuste { get; set; }
        
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }

        public int IdFuncionario { get; set; }

        [ForeignKey("IdFuncionario")]
        public Funcionario Funcionario { get; set; }
    }
}