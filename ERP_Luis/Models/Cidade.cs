using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_JOSEREIS.Models
{
    public class Cidade
    {
        [Key]
        public int IdCidade { get; set; }

        [Required(ErrorMessage = "O campo Nome da Cidade é obrigatório")]
        [Display(Name="Nome da Cidade")]
        [Range(5, 60, ErrorMessage = "O campo deve ser preenchido com no minimo 5 e no maximo 60 caracteres")]
        public string NomeCidade { get; set; }

        public int IdEstado { get; set; }
        [ForeignKey("IdEstado")]
        public Estado Estado { get; set; }
    }
}