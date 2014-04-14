using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.Models
{
    public class Unidade
    {
        [Key]
        public int IdUnidade { get; set; }
        
        [MaxLength(45)]
        public string descricao { get; set; }

        public IList<Item> Itens { get; set; }
    }
}