using Investimento.Interfaces;
using System;

namespace Investimento
{
    class RealizadorDeInvestimentos
    {

        public void RealizaInvestimento(Models.Investimento investimento, ITipoInvestimento tipoInvestimento)
        {
            var resultado = tipoInvestimento.RetornaRendimento(investimento);

            Console.WriteLine(resultado);
        }

    }
}
