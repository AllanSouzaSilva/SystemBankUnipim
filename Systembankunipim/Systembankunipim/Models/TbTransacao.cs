using System;
using System.Collections.Generic;

namespace Systembankunipim.Data
{
    public partial class TbTransacao
    {
        public int IdTransacao { get; set; }
        public int IdCarteira { get; set; }
        public int IdTipoTransacao { get; set; }
        public decimal ValorTransacao { get; set; }
        public int CarteiraDestino { get; set; }
        public int AgenciaDestino { get; set; }
        public int ContaDestino { get; set; }

        public virtual TbCarteira IdCarteiraNavigation { get; set; }
        public virtual TbTipoTransacao IdTipoTransacaoNavigation { get; set; }
    }
}
