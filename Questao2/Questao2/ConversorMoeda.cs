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
            double percent = valor * 0.06;
            reais = (valor * cotacao);
            reais += percent;
            return Math.Round(reais, 2);
        }
    }
}
