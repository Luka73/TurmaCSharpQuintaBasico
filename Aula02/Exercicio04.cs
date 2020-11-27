using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02
{
    public class Exercicio04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Você é estudante? [S/N]"); //s
            string estudante = Console.ReadLine().ToUpper();
            //bool bEstudante = Console.ReadLine().Equals("S", StringComparison.OrdinalIgnoreCase); 

            //"N" == "S" --> false
            // 7 == 5
            // "Luana" == "Marta"

            //bool ehEstudante = estudante == "S" || estudante == "s";

            // 5 + 4 == 9 --> true
            // 5 + 2 == 10 --> false

            string msg = (estudante.Equals("S") || (idade <= 21 || idade >= 65))
                        ? "Pode pagar meia entrada"
                        : "Não pode pagar meia entrada!";


            /* if (estudante.Equals("S") || (idade <= 21 || idade >= 65))  // -> Se der false SEMPRE cai o else
             {
                 Console.WriteLine("Pode pagar meia entrada");               
             } 
             else
             {
                 Console.WriteLine("Não pode pagar meia entrada!");
             }*/

            Console.WriteLine(msg);

        }
    }
}
