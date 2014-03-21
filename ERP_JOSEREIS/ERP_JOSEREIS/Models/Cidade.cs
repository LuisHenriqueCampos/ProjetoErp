using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ERP_JOSEREIS.Models
{
    public class Cidade
    {
        [Key]
        public int IdCidade { get; set; }
        public string Nome { get; set; }
        public Estado Estado { get; set; }
    }
}