using ExemploLivrariaModulo07OOB.Endereço;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploLivrariaModulo07OOB.Endereco
{
    public class Endereco 
    {
        public Endereco()
        {
            this.Bairro = new Bairro();
        }
        public int? Numero { get; set; }
        public string Rua { get; set; }
        public Bairro Bairro { get; set; }
        public string LocalReferencia { get; set; }

    }

}
