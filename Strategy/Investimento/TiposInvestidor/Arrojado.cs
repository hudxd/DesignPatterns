using System;
using System.Collections.Generic;
using System.Text;
using Investimento.Interfaces;

namespace Investimento.TiposInvestidor
{
    public class Arrojado : ITipoInvestimento
    {
        public double RetornaRendimento(Models.Investimento investimento)
        {
            //Critério:
            // 20% chance de render 5%
            // 30% chance de render 3%
            // 50% chance de render 0.6%

            var chance = new Random().Next(1, 100);

            if (chance <= 20)
                return investimento.Valor * 1.05;
            else if (chance <= 50)
                return investimento.Valor * 1.03;
            else
                return investimento.Valor * 1.006;

        }
    }
}
