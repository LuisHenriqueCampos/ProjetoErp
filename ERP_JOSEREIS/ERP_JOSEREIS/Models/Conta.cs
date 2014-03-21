using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ERP_JOSEREIS.Models
{
    public class Conta
    {
        [Key]
        public Int32 IdConta { get; set; }
        public String Descricao { get; set; }
        public Int16 Tipo { get; set; }
        public ICollection<Lancamento> Lancamentos { get; set; }


    }
}