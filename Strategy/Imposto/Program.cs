using System;
using Imposto.Impostos;

namespace Imposto
{
    class Program
    {
        static void Main(string[] args)
        {
            var icms = new ICMS();
            var iss = new ISS();
            var iccc = new ICCC();

            var orcamento = new Orcamento(10000.00);

            new CalculadorDeImpostos().RealizaCalculo(orcamento, icms);
            new CalculadorDeImpostos().RealizaCalculo(orcamento, iss);
            new CalculadorDeImpostos().RealizaCalculo(orcamento, iccc);
        }
    }
}
