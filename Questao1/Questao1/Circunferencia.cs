using System;
using System.Collections.Generic;
using System.Text;

namespace Questao1
{
    class Circunferencia
    {
        public double raio, circunferencia, volume;
        public static double Pi = 3.14;
        public void Calculo()
        {
            circunferencia = (2 * Pi) * raio;
            volume = Math.Round((4 * Pi) * Math.Pow(raio, 3) / 3, 2);
        }
    }
}
