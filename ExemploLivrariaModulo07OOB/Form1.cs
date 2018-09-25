using ExemploLivrariaModulo07OOB.Endereço;
using ExemploLivrariaModulo07OOB.Transacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploLivrariaModulo07OOB
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntradaLivro entrada = new EntradaLivro();
            entrada.Codigo = 1;
            entrada.NumeroNota = 123;
            entrada.Fornecedor.Codigo = 12;
            entrada.Fornecedor.tipoPessoa = EnumTipoPessoa.Fornecedor;
            entrada.Fornecedor.EnderecoCompleto.Numero = 524;
            entrada.Fornecedor.EnderecoCompleto.Bairro.Cidade.Pais. = 
        }
    }
}
