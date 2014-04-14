using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.Models
{
    public class TipoItem
    {
        [Key]
        public int IdTipoItem { get; set; }
        
        [MaxLength(45)]
        public string Descricao { get; set; }

        public IList<Item> itens { get; set; }
    }
}