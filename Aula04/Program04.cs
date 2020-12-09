using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
    public class Program04
    {
        static void Main(string[] args)
        {

            int i = 15; // --> inicio

            while(i >= 1) // --> condição
            {
                Console.WriteLine(i);
                i--; // --> incremento
            }

            Console.ReadKey();
        }
    }
}
