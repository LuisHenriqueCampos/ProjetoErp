using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.Models
{
    public class Departamento
    {
        [Key]
        public int IdDepartamento { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage="Descrição Obrigatória")]
        public string Descricao { get; set; }

        public List<Funcionario> Funcionarios { get; set; }
    }
}