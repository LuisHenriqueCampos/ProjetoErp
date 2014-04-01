using ERP_JOSEREIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_JOSEREIS.ViewModels
{
    public class ClienteViewModel
    {
        public Cliente Cliente { get; set; }
        public PessoaFisica PessoaFisica { get; set; }
        public PessoaJuridica PessoaJuridica { get; set; }

        public ClienteViewModel(Cliente cliente, PessoaFisica pf)
        {
            Cliente = cliente;
            PessoaFisica = pf;
        }

        public ClienteViewModel(Cliente cliente, PessoaJuridica pj)
        {
            Cliente = cliente;
            PessoaJuridica = pj;
        }
    }
}