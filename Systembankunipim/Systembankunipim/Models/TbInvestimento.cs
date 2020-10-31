using System;
using System.Collections.Generic;

namespace Systembankunipim.Data
{
    public partial class TbInvestimento
    {
        public int IdInvestimento { get; set; }
        public int IdCarteira { get; set; }
        public int IdTipoInvestimento { get; set; }
        public int Quantidade { get; set; }

        public virtual TbCarteira IdCarteiraNavigation { get; set; }
        public virtual TbTipoInvestimento IdTipoInvestimentoNavigation { get; set; }
    }
}
