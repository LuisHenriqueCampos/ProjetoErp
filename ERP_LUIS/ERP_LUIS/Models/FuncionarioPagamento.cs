using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.Models
{
    public class FuncionarioPagamento
    {
        [Key]
        public int IdMes { get; set; }

        public DateTime MesReferencia { get; set; }
        public decimal TotalHoraExtra { get; set; }
        public DateTime DataPagamentol { get; set; }
        public decimal ValorPagamento { get; set; }

        public int IdFuncionario { get; set; }

        [ForeignKey("IdFuncionario")]
        public Funcionario Funcionario { get; set; }
    }
}