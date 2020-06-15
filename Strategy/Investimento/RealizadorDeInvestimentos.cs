using System;
using System.Collections.Generic;
using System.Text;
using Investimento.Interfaces;

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
