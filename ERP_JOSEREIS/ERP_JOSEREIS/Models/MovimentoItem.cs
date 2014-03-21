using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ERP_JOSEREIS.Models
{
    public class MovimentoItem
    {
        [Key]
        public int IdMovimentoItem { get; set; }
        public Item Item { get; set; }
        public Movimento Movimento { get; set; }
        public float Quantidade { get; set; }
        public float ValorUnitario { get; set; }

    }
}