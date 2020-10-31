using System;
using System.Collections.Generic;

namespace Systembankunipim.Data
{
    public partial class TbCarteira
    {
        public int IdCarteira { get; set; }
        public int IdCliente { get; set; }
        public decimal SaldoCarteira { get; set; }
        public decimal UltimoDeposito { get; set; }
        public decimal UltimoSaque { get; set; }
        public DateTime DataUltimaTransacao { get; set; }
        //FK
        public virtual TbCliente IdClienteNavigation { get; set; }
        //Ralções entre as entidades
        public virtual ICollection<TbInvestimento> TbInvestimento { get; set; }
        public virtual ICollection<TbTransacao> TbTransacao { get; set; }
        
        public TbCarteira()
        {
            TbInvestimento = new HashSet<TbInvestimento>();
            TbTransacao = new HashSet<TbTransacao>();
        }

    }
}
