using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace Systembankunipim.Data
{
    public partial class TbCliente
    {
        public TbCliente()
        {
            TbCarteira = new HashSet<TbCarteira>();
        }

        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DtNasc { get; set; }

        public string Telefone { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Informe o email do usuário", AllowEmptyStrings = false)]
        public string Email { get; set; }
        public string Usuario { get; set; }
        
        
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public virtual ICollection<TbCarteira> TbCarteira { get; set; }


    }
}
