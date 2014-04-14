using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.Models
{
    public class Movimento
    {
        [Key]
        public int IdMovimento { get; set; }

        [Required(ErrorMessage="Data Obrigatório")]
        public DateTime Data { get; set; }

        public int IdTipoMovimento { get; set; }
        public int IdFormaPagamento { get; set; }
        public int IdPessoa { get; set; }

        [ForeignKey("IdTipoMovimento")]
        public TipoMovimento TipoMovimento { get; set; }
        
        [ForeignKey("IdPessoa")]
        public Pessoa Pessoa { get; set; }
        
        [ForeignKey("IdFormaPagamento")]
        public FormaPagamento FormaPagamento { get; set; }
    }
}