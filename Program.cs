using System;

namespace SBF_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do produto em reais: R$");
            double produto = double.Parse(Console.ReadLine());

            double convertDolar = (produto/5.06);
            double convertEuro =  (produto/6.10);
            double convertIndian = (produto*14.76);

            Console.WriteLine("O valor em Dólar é ${0:00} ", convertDolar);
            Console.WriteLine("O valor em Euro é {0:00}", convertEuro);
            Console.WriteLine("O valor em Indian Rupee é {0:00}", convertIndian);


        }
    }
}
