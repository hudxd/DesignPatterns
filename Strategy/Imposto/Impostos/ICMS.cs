using Imposto.Interfaces;

namespace Imposto.Impostos
{
    class ICMS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
