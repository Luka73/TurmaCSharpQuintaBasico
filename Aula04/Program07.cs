using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
    public class Program07
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int n = int.Parse(Console.ReadLine());
            //1, 1, 2, 3, 5, 8

            int termo1 = 1;
            int termo2 = 1;
            int termo3;

            if (n >= 3 && n <= 20)
            {
                Console.Write(termo1 + " ");
                Console.Write(termo2 + " ");

                for(int i = 3; i <= n; i++)
                {
                    termo3 = termo2 + termo1;
                    Console.Write(termo3 + " ");
                    termo1 = termo2;
                    termo2 = termo3;
                }
            } 
            else
            {
                Console.WriteLine("Digite um número válido!");
            }

            Console.ReadKey();
        }
    }
}
