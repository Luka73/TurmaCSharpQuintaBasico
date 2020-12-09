using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
    public class Program06
    {
        static void Main(string[] args)
        {
            for(int x = 1; x <= 10; x++)
            {
                int y = 6 * x;
                Console.WriteLine("6 x {0} = {1}\n", x, y);
            }

            //6 x 1 = 6
            //6 x 2 = 12
            //6 x 3 = 18
            //...
            //6 x 9 = 54
            //6 x 10 = 60
            Console.ReadKey();
        }
    }
}
