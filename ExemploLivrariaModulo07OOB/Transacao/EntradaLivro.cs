using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploLivrariaModulo07OOB.Transacao
{
    public class EntradaLivro
    {
        public EntradaLivro()
        {
            this.ListaLivros = new List<Livro>();
            this.Fornecedor = new Fornecedor();
        }
        public int Codigo { get; set; }
        public long NumeroNota { get; set; }
        public List<Livro> ListaLivros { get; set; }
        public Fornecedor Fornecedor { get; set; }

        public double CalcularPrecoTotalEntrada()
        {
            double precoCompraTotal = 0;
            foreach (Livro livro in this.ListaLivros)
            {
                precoCompraTotal += livro.PrecoCompra;
            }
            return precoCompraTotal;
        }
    }

}
