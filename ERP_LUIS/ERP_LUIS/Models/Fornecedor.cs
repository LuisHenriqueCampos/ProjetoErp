using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.Models
{
    public class Fornecedor
    {
        [Key]
        public int IdFornecedor { get; set; }

        [ForeignKey("IdFornecedor")]
        public Pessoa pessoa { get; set; }
    }
}