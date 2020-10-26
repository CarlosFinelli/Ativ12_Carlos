using System;
using System.Collections.Generic;
using System.Text;

namespace Questao2
{
    class ConversorMoeda
    {
        public double cotacao, valor;
        public double reais;

        public double Conversao()
        {
            reais = (valor * cotacao) + valor * 0.06;
            return Math.Round(reais, 2);
        }
    }
}
