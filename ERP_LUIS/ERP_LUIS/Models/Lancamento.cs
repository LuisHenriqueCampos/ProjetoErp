using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.Models
{
    public class Lancamento
    {
        [Key]
        public int IdLancamento { get; set; }
        
        public DateTime DataPagamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorBaixa { get; set; }
        public short IdParcela { get; set; }
        public short Tipo { get; set; }

        public Conta Conta { get; set; }
        public Movimento Movimento { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}