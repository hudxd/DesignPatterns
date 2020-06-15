using System;
using System.Collections.Generic;
using System.Text;
using Investimento.Interfaces;

namespace Investimento.TiposInvestidor
{
    public class Moderado : ITipoInvestimento
    {
        public double RetornaRendimento(Models.Investimento investimento)
        {
            // Critério: 50% de render 2.5% e 50% de render 0.7%
            var retorna0025 = new Random().Next(2) == 1;

            if (retorna0025)
                return investimento.Valor * 1.025;
            else
                return investimento.Valor * 1.007;
        }
    }
}
