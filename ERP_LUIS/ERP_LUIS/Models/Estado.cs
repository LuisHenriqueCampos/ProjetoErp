using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.Models
{
    public class Estado
    {
        [Key]
        public int IdEstado {get; set;}
        
        [MaxLength(50)]
        [Required(ErrorMessage="Nome Obrigatório")]
        public string Nome { get; set; }

        [MaxLength(2)]
        [Required(ErrorMessage="Sigla Obrigatório")]
        public string Sigla { get; set; }
        
        public ICollection<Cidade> Cidades { get; set; }
    }
}