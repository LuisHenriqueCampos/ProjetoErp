using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.Models
{
    public class FormaPagamento
    {
        [Key]
        public int IdFormaPagamento { get; set; }
        
        [MaxLength(45)]
        [Required(ErrorMessage="Descrição Obrigatória")]
        public string Descricao { get; set; }

        public List<Movimento> Movimentos { get; set; }
    }
}