using System;
using System.Collections.Generic;

namespace Systembankunipim.Data
{
    public partial class TbTipoInvestimento
    {
        public TbTipoInvestimento()
        {
            TbInvestimento = new HashSet<TbInvestimento>();
        }

        public int IdTipoInvestimento { get; set; }
        public string DescricaoInvestimento { get; set; }
        public decimal ValorInvestimento { get; set; }

        public virtual ICollection<TbInvestimento> TbInvestimento { get; set; }
    }
}
