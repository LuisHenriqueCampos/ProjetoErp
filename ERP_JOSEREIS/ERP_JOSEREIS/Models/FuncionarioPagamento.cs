using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ERP_JOSEREIS.Models
{
    public class FuncionarioPagamento
    {
        [Key]
        public Int32 IdMes { get; set; }
        public DateTime MesReferencia { get; set; }
        public float TotalHoraExtra { get; set; }
        public DateTime DataPagamento { get; set; }
        public float ValoPagamento { get; set; }
        public Pessoa IdPessoa { get; set; }
    }
}