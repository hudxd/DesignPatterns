using System;
using Imposto.Interfaces;

namespace Imposto
{
    class CalculadorDeImpostos
    {

        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            var resultado = imposto.Calcula(orcamento);

            Console.WriteLine(resultado);
        }

    }
}
