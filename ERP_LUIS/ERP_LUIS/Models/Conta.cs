using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.Models
{
    public class Conta
    {
        [Key]
        public int IdConta { get; set; }
        
        [MaxLength(45)]
        public string Descricao { get; set; }

        public short Tipo { get; set; }
    }
}