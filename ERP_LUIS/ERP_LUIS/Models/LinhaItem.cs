using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.Models
{
    public class LinhaItem
    {
        [Key]
        public int IdLinhaItem { get; set; }
        
        [MaxLength(45)]
        public string Descricao { get; set; }

        public IList<Item> Itens { get; set; }
    }
}