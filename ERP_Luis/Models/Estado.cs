using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ERP_JOSEREIS.Models
{
    public class Estado
    {
        [Key]
        public int IdEstado { get; set; }

        [Required(ErrorMessage = "O campo Nome do Estado é obrigatório")]
        [Display(Name="Nome do Estado")]
        [Range(5, 50, ErrorMessage = "O campo deve ser preenchido com no minimo 5 e no maximo 50 caracteres")]
        public string NomeEstado { get; set; }

        [Required(ErrorMessage = "O campo Sigla é obrigatório")]
        [Display(Name="Sigla")]
        [Range(1, 2, ErrorMessage = "O campo deve ser preenchido com no minimo 1 e no maximo 2 caracteres")]
        public string Sigla { get; set; }

        public ICollection<Cidade> Cidades { get; set; }
    }
}