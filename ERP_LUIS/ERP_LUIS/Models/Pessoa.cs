using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.Models
{
    public class Pessoa
    {
        [Key]
        public int IdPessoa {get; set;}
        
        [Required(ErrorMessage="Nome Obrigatório")]
        [MaxLength(60)]
        public string Nome {get; set;}
        
        [Required(ErrorMessage="Data de Cadastro Obrigatório")]
        public DateTime DataCadastro {get; set;}
        
        [MaxLength(50)]
        public string Rua { get; set; }
        
        [MaxLength(10)]
        public string Numero { get; set; }
        
        [MaxLength(50)]
        public string Bairro { get; set; }
        
        [MaxLength(8)]
        public string CEP { get; set; }
        
        [MaxLength(10)]
        public string TelefoneComercial { get; set; }
        
        [MaxLength(10)]
        public string TelefoneResidencial { get; set; }
        
        [ForeignKey("IdCidade")]
        public Cidade Cidade { get; set; }

        public int IdCidade { get; set; }

        public List<Movimento> Movimentos { get; set; }
    }
}