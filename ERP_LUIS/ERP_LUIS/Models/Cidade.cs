using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.Models
{
    public class Cidade
    {
        [Key]
        public int IdCidade {get; set;}

        [Required(ErrorMessage="Nome Obrigatório")]
        [MaxLength(60)]
        public string Nome { get; set; }

        public int IdEstado { get; set; }

        [ForeignKey("IdEstado")]
        public Estado Estado { get; set; }
    }
}