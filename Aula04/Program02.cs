using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
    public class Program02
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i <= 10)
            {
                Console.WriteLine("Seja bem-vindo, Aluno " + i);
                i = i + 1;
            }

            Console.WriteLine("Digite o início: ");
            int inicio = int.Parse(Console.ReadLine());
            
            for(int j = 1; j <= 10; j = j + 1)
            {
                Console.WriteLine("Seja bem-vindo, Aluno " + j);
            }


            Console.ReadKey();
        }
    }
}
