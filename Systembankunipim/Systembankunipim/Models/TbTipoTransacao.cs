using System;
using System.Collections.Generic;

namespace Systembankunipim.Data
{
    public partial class TbTipoTransacao
    {
        public TbTipoTransacao()
        {
            TbTransacao = new HashSet<TbTransacao>();
        }

        public int IdTipoTransacao { get; set; }
        public string DescricaoTransacao { get; set; }

        public virtual ICollection<TbTransacao> TbTransacao { get; set; }
    }
}
