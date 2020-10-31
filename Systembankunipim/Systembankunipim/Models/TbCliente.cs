using System;
using System.Collections.Generic;

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
        public DateTime DtNasc { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public virtual ICollection<TbCarteira> TbCarteira { get; set; }
    }
}
