using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.Models
{
    public class MovimentoItem
    {
        [Key]
        public int IdMovimentoItem { get; set; }
        
        [Required(ErrorMessage="Quantidade Obrigatória")]
        public float Quantidade { get; set; }
        
        [Required(ErrorMessage="Valor Unitário Obrigatório")]
        public float ValorUnitario { get; set; }

        public int IdItem { get; set; }
        public int IdMovimento { get; set; }

        [ForeignKey("IdItem")]
        public Item Item { get; set; }
        
        [ForeignKey("IdMovimento")]
        public Movimento movimento { get; set; }
    }
}