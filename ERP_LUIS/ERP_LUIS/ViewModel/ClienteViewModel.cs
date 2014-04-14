using ERP_ANDERSON.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.ViewModel
{
    public class ClienteViewModel
    {
        public ClienteViewModel(Cliente cliente, PessoaFisica pessoaFisica)
        {
            Cliente = cliente;
            PessoaFisica = pessoaFisica;
        }

        public ClienteViewModel(Cliente cliente, PessoaJuridica pessoaJuridica)
        {
            Cliente = cliente;
            PessoaJuridica = pessoaJuridica;
        }

        public Cliente Cliente { get; set; }
        public PessoaFisica PessoaFisica { get; set; }
        public PessoaJuridica PessoaJuridica { get; set; }
    }
}