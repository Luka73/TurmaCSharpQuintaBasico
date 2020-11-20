using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02
{
    public class Exercicio07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a termperatura em Fahrenheit: ");
            double f = double.Parse(Console.ReadLine());

            double c = (f - 32) * (5.0 / 9);

            Console.WriteLine("Resultado: " + (int) c);
        }
    }
}
