﻿using Imposto.Interfaces;

namespace Imposto.Impostos
{
    public class ISS : IImposto
    {
  
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
