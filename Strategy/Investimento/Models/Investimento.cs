using System;
using System.Collections.Generic;
using System.Text;

namespace Investimento.Models
{
    public class Investimento
    {

        public double Valor { get; set; }

        public Investimento(double valor)
        {
            this.Valor = valor;
        }

    }
}
