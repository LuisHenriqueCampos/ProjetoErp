using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ERP_JOSEREIS.Models
{
    public class Lancamento
    {
        [Key]
        public Int32 IdLancamento { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public float Valor { get; set; }
        public float ValorBaixa { get; set; }
        public Int16 IdParcela { get; set; }
        public Int16 Tipo { get; set; }
        public Conta Conta { get; set; }
        public Movimento Movimento { get; set; }
        public Pessoa Pessoa { get; set; }

    }
}