﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploLivrariaModulo07OOB.Endereço
{
    public class Bairro : Entidade
    {
        public Bairro()
        {
            this.Cidade = new Cidade();
        }
        public Cidade Cidade { get; set; }
    }
}