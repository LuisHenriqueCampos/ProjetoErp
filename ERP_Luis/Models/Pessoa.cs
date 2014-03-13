using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_JOSEREIS.Models
{
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [Display(Name="Nome")]
        [Range(5, 60, ErrorMessage = "O campos deve ser preenchido com no minimo 5 e no maximo 60 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Data de Cadastro é obrigatório")]
        [Display(Name="Data de Cadastro")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataCadastro { get; set; }

        [Display(Name="Rua")]
        [Range(5, 50, ErrorMessage = "O campo deve ser preenchido com no minimo 5 e no maximo 50 caracteres")]
        public string Rua { get; set; }

        [Display(Name="Numero")]
        [Range(1, 10, ErrorMessage = "O campo deve ser preenchido com no minimo 1 e no maximo 10 caracteres")]
        public string Numero { get; set; }

        [Display(Name="Bairro")]
        [Range(2, 50, ErrorMessage = "O campo deve ser preenchido com no minimo 2 e no maximo 50 caracteres")]
        public string Bairro { get; set; }

        [Display(Name="CEP")]
        [Range(8, 8, ErrorMessage = "O campo deve ser preenchido com 8 caracteres")]
        public string CEP { get; set; }

        [Display(Name="Telefone Comercial")]
        [Range(10, 11, ErrorMessage = "O campo deve ser preenchido com no minimo 10 e no maximo 11 caracteres")]
        public string TelefoneComercial { get; set; }

        [Display(Name="Telefone Residencial")]
        [Range(10, 11, ErrorMessage = "O campo deve ser preenchido com no minimo 10 e no maximo 11 caracteres")]
        public string TelefoneResidencial { get; set; }

        public int IdCidade { get; set; }
        [ForeignKey("IdCidade")]
        public Cidade Cidade { get; set; }

    }
}