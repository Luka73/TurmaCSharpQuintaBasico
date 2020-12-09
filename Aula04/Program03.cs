using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
    class Program03
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                if (i == 3)
                {
                    break;
                }
                Console.WriteLine(i);
                i += 2; //--> i = i + 2;
                i += 10; //--> i = i + 10;

                i += 1; // --> i = i + 1;
                i++; // --> i = i + 1;
            }


            Console.WriteLine("************************");


            int j = 0;
            while (j < 10) 
            {
                j = j + 1;
                
                if (j == 3)
                {
                    continue;
                }

                Console.WriteLine(j);
            }

            Console.ReadKey();
        }
    }
}
