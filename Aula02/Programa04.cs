using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02
{
    public class Programa04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual foi o total da sua compra: ");
            double preco = Convert.ToDouble(Console.ReadLine()); //10.00

            Console.WriteLine("Qual a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine()); //32

            if (idade <= 21 && preco > 20)
            {
                preco -= 5;
                preco -= 2;
            }

            if (idade > 21 || preco > 20)
            {
                preco -= 2;
            }

            //if(CPF && RG && CERTIDAO || CHN) --> CPF == true && RG == true 
            //if(CPF || RG) --> CPF == true || RG == true
            //if(!7 > 5) --> false
            //if(!7 < 5) --> true 

            //(7 > 5) || (8 == 2) && (9 < 1)

            // (7 > 5) --> true
            // (8 == 2) --> false
            // (9 < 1) --> false

            // true || false && false
            // true || false
            // true

            // | --> pipe

        }
    }
}
