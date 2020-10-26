using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorMoeda conversor = new ConversorMoeda();
            Console.Write("Insira a cotação do Dólar: ");
            conversor.cotacao = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira a quantidade de dólares que você quer comprar: ");
            conversor.valor = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"O valor em reais que você irá pagar é: {conversor.Conversao()}");
        }
    }
}
