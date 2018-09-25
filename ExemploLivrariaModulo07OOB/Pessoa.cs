using ExemploLivrariaModulo07OOB.Endereço;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploLivrariaModulo07OOB
{
    public abstract class Pessoa : Entidade
    {
        public Pessoa()
        {
            this.EnderecoCompleto = new EnderecoCompleto();
        }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public EnumTipoPessoa tipoPessoa { get; set; }
        public EnderecoCompleto EnderecoCompleto { get; set; }
    }
}
