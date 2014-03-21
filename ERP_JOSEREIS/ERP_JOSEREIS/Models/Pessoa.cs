using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ERP_JOSEREIS.Models
{
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }
        [Required]
        [MaxLength(60)]
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string TelefoneComercial { get; set; }
        public string TelefoneResidencial { get; set; }
        public Cidade Cidade { get; set; }
    }
}