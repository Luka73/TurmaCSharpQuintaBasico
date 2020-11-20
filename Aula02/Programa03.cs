using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02
{
    public class Programa03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual foi o total da sua compra: ");
            double preco = Convert.ToDouble(Console.ReadLine()); //70.00

            Console.WriteLine("Qual a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (preco > 20)
            {
                preco -= 2;
            }

            if (idade <= 21)
                preco -= 5; //preco = preco - 5
            else
                preco = preco - 2;

            Console.WriteLine("Total a pagar: " + preco);

            // 7 + 5 == 12

            if (7 > 5 == true) { } //--> true
            if (8 == 8 == true) { } //--> true
            if (9 != 3) { } //--> true
            if (5 <= 5) { } //--> true
            if (5 > 7 == false) { } //--> false


            int teste = (idade > 15) ? 5 : 7; //if ternário*/
        }
    }
}
