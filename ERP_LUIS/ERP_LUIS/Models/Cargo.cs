using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.Models
{
    public class Cargo
    {
        [Key]
        public int IdCargo { get; set; }
        
        [MaxLength(50)]
        public string Descricao { get; set; }
        
        public List<Funcionario> Funcionarios { get; set; }
    }
}