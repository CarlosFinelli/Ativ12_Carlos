using System;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circunferencia c = new Circunferencia();
            Console.Write("Insira o valor do raio: ");
            c.raio = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            c.Calculo();
            Console.WriteLine($"O valor da circunferência é: {c.circunferencia}");
            Console.WriteLine($"O valor do volume é: {c.volume}");
            Console.ReadLine();

        }
    }
}
