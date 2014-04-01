using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_JOSEREIS.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        [ForeignKey("IdCliente")]
        public Pessoa Pessoa { get; set; }
    }
}