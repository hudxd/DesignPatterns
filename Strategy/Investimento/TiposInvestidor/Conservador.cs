using Investimento.Interfaces;

namespace Investimento.TiposInvestidor
{
    class Conservador : ITipoInvestimento
    {
        public double RetornaRendimento(Models.Investimento investimento)
        {
            return investimento.Valor * 1.08;
        }

    }
}
