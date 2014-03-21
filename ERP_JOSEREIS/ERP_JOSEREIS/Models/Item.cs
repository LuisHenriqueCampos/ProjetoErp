using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ERP_JOSEREIS.Models
{
    public class Item
    {
        [Key]
        //public Int32 Item { get; set; }
        public String Descricao { get; set; }
        public float QuantidadeMinimaEsoque { get; set; }
        public TipoItem TipoItem { get; set; }
        //public Unidade Unidade { get; set; }
        //public LinhaItem LinhaItem { get; set; }


    }
}