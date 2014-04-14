using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        [ForeignKey("IdCliente")]
        public Pessoa pessoa { get; set; }
        public bool Preferencial { get; set; }
    }
}