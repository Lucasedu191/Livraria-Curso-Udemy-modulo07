using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploLivrariaModulo07OOB
{
    public class Estado
    {
        public Estado()
        {
            this.Pais = new Pais();
        }
        public Pais Pais { get; set; }
        public string UF { get; set; }

    }
}
