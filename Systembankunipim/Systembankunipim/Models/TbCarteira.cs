using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace Systembankunipim.Data
{
    public partial class TbCarteira
    {
        
        public int IdCarteira { get; set; }
        [Display(Name = "Cliente")]
        public int IdCliente { get; set; }
        [Display(Name = "Saldo Carteira")]
        public decimal SaldoCarteira { get; set; }
        [Display(Name = "Ultimo Deposito")]
        public decimal UltimoDeposito { get; set; }
        [Display(Name = "Ultimo Saque")]
        public decimal UltimoSaque { get; set; }
        
       
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data da Ultima Transação")]
        public DateTime DataUltimaTransacao { get; set; }
      
        [Display(Name ="Nome do Usuário")]
        public virtual TbCliente IdClienteNavigation { get; set; }
        //Ralações entre as entidades
        public virtual ICollection<TbInvestimento> TbInvestimento { get; set; }
        public virtual ICollection<TbTransacao> TbTransacao { get; set; }
        
        public TbCarteira()
        {
            TbInvestimento = new HashSet<TbInvestimento>();
            TbTransacao = new HashSet<TbTransacao>();
        }

    }
}
