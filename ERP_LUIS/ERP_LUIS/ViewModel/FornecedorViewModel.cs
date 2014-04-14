using ERP_ANDERSON.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.ViewModel
{
    public class FornecedorViewModel
    {
        public FornecedorViewModel(Fornecedor fornecedor, PessoaFisica pessoaFisica)
        {
            Fornecedor = fornecedor;
            PessoaFisica = pessoaFisica;
        }

        public FornecedorViewModel(Fornecedor fornecedor, PessoaJuridica pessoaJuridica)
        {
            Fornecedor = fornecedor;
            PessoaJuridica = pessoaJuridica;
        }

        public Fornecedor Fornecedor { get; set; }
        public PessoaFisica PessoaFisica { get; set; }
        public PessoaJuridica PessoaJuridica { get; set; }
    }
}