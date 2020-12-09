using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
    public class Programa05
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            int i = 1;
            while(i <= n)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.ReadKey();
        }
    }
}
