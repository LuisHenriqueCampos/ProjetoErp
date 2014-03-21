using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ERP_JOSEREIS.Models
{
    public class TipoMovimento
    {
        [Key]
        public Int32 IdTipoMovimento { get; set; }
        public String Descricao { get; set; }
        public Char OperacaoEstoque { get; set; }
        public Boolean EntregaFornecedo { get; set; }
        public Boolean SolicitanteInterno { get; set; }
        public Boolean PedidoCliente { get; set; }
        public ICollection<Movimento> Movimento { get; set; }

    }
}