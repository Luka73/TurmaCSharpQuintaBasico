using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02
{
    public class Programa01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o primeiro número: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine(nome + " a sua soma deu " + soma);

        }
    }
}
