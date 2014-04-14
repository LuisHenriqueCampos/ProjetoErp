using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.Models
{
    public class TipoMovimento
    {
        [Key]
        public int IdTipoMovimento { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage="Descrição é Obrigatório")]
        public string Descricao { get; set; }
        
        [MaxLength(1)]
        [Required(ErrorMessage="Operação de Estoque Obrigatório")]
        public string OperacaoEstoque { get; set; }
        
        public bool EntregaFornecedor { get; set; }
        public bool SolicitanteInterno { get; set; }
        public bool PedidoCliente { get; set; }

        public List<Movimento> Movimentos { get; set; }

    }
}