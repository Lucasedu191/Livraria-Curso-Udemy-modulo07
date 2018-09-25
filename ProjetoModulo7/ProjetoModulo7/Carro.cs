using System;

namespace ProjetoModulo7
{
    public class Carro : IVeiculo
    {
        public string cor { get; set; }
        public string modelo { get; set; }
        public double velocidadeMaxima { get; set; }
        public int qtdRodas { get; set; }
        public int qtdPortas { get; set; }

        public string Acelerar()
        {
            throw new NotImplementedException();
        }

        public string Ligar()
        {
            throw new NotImplementedException();
        }

        public string Ligar(double vel)
        {
            throw new NotImplementedException();
        }

        public string Ligar(int velocidade)
        {
            throw new NotImplementedException();
        }
    }
}
