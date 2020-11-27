using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Systembankunipim.Data
{
    public partial class TbTipoInvestimento
    {
        public TbTipoInvestimento()
        {
            TbInvestimento = new HashSet<TbInvestimento>();
        }
        [Display(Name = "Tipo de Investimento")]
        public int IdTipoInvestimento { get; set; }
        public string DescricaoInvestimento { get; set; }
        public decimal ValorInvestimento { get; set; }

        public virtual ICollection<TbInvestimento> TbInvestimento { get; set; }
    }
}
