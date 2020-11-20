using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02
{
    public class Programa02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual foi o total da sua compra: ");
            double preco = double.Parse(Console.ReadLine()); //70.00

            if (preco > 20)
            { //escopo
                preco = preco - 2; //68
            }

            Console.WriteLine("Total a pagar: $" + preco);

        }
    }
}
