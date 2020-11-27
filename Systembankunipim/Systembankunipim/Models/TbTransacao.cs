using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Systembankunipim.Data
{
    public partial class TbTransacao
    {
        public int IdTransacao { get; set; }
       
        public int IdCarteira { get; set; }
        [Display(Name = "Tipo da transação")]
        public int IdTipoTransacao { get; set; }
        [Display(Name = "Valor da transação")]
        public decimal ValorTransacao { get; set; }
        [Display(Name = "Carteira Destino")]
        public int CarteiraDestino { get; set; }
        [Display(Name = "Agencia Destino ")]
        public int AgenciaDestino { get; set; }
        [Display(Name = "Conta Destino")]
        public int ContaDestino { get; set; }
        [Display(Name = "Numero da Carteira")]
        public virtual TbCarteira IdCarteiraNavigation { get; set; }
        [Display(Name = "Tipo da Transação")]
        public virtual TbTipoTransacao IdTipoTransacaoNavigation { get; set; }
    }
}
