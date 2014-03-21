using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ERP_JOSEREIS.Models
{
    public class Movimento
    {
        [Key]
        public Int32 IdMovimento { get; set; }
        public DateTime Data { get; set; }
        public TipoMovimento TipoMovimento { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public Pessoa Pessoa { get; set; }
        public ICollection<Lancamento> Lancamento { get; set; }
        public ICollection<MovimentoItem> MovimentoItens{ get; set; }


    }
}