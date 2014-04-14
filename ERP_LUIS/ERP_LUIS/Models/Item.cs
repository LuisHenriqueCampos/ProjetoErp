using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.Models
{
    public class Item
    {
        [Key]
        public int IdItem { get; set; }
        
        [MaxLength(60)]
        public string Descricao { get; set; }
        public decimal QuantidadeMinimaEstoque { get; set; }

        public int IdTipoItem { get; set; }
        public int IdUnidade { get; set; }
        public int IdLinhaItem { get; set; }

        [ForeignKey("IdTipoItem")]
        public TipoItem TipoItem { get; set; }
        
        [ForeignKey("IdUnidade")]
        public Unidade Unidade { get; set; }
        
        [ForeignKey("IdLinhaItem")]
        public LinhaItem LinhaItem { get; set; }
    }
}