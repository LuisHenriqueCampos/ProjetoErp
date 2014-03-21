using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_JOSEREIS.Models
{
    public class SalarioReajuste
    {
        public Int32 IdSalarioReajuste { get; set; }
        public DateTime Data { get; set; }
        public float Valor { get; set; }
        public Funcionario Funcionario { get; set; }


    }
}