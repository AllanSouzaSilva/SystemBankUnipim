using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Systembankunipim.Data
{
    public partial class TbInvestimento
    {
        public int IdInvestimento { get; set; }
        public int IdCarteira { get; set; }
        public int IdTipoInvestimento { get; set; }
        public int Quantidade { get; set; }
        [Display(Name = "Numero da Carteira")]
        public virtual TbCarteira IdCarteiraNavigation { get; set; }
        [Display(Name = "Tipo de Investimento")]
        public virtual TbTipoInvestimento IdTipoInvestimentoNavigation { get; set; }
    }
}
