using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ERP_JOSEREIS.Models
{
    public class FormaPagamento
    {
        [Key]
        public Int32 IdFormaPagamento { get; set; }
        public String Descricao { get; set; }
        public ICollection<Movimento> Movimentos { get; set; }


    }
}