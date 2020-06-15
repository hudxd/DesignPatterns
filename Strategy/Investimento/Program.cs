using System;
using Investimento.TiposInvestidor;

namespace Investimento
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var investimento = new Models.Investimento(1000);

            var conservador = new Conservador();
            var moderado = new Moderado();
            var arrojado = new Arrojado();

            new RealizadorDeInvestimentos().RealizaInvestimento(investimento, conservador);
            new RealizadorDeInvestimentos().RealizaInvestimento(investimento, moderado);
            new RealizadorDeInvestimentos().RealizaInvestimento(investimento, arrojado);

        }
    }
}
