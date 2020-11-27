using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03
{
    public class Desafio01
    {
        static void Main(string[] args) { 
            Console.WriteLine("Digite seu dia de nascimento: ");
            int dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu mês de nascimento: ");
            int mes = int.Parse(Console.ReadLine());

            string signo = "";

            if(dia > 31 || dia < 1)
            {
                Console.WriteLine("Dia inválido");
                return;
            }

            switch(mes)
            {
                case 1:
                    /* if(dia <= 20)
                     {
                         Console.WriteLine("Capricórnio");
                     }
                     else
                     {
                         Console.WriteLine("Aquário");
                     }*/

                    signo = (dia <= 20) ? "Capricórnio" : "Aquário";

                    break;
                case 2:
                    /*if (dia <= 19)
                    {
                        Console.WriteLine("Aquário");
                    }
                    else
                    {
                        Console.WriteLine("Peixes");
                    }*/


                    signo = (dia <= 19) ? "Capricórnio" : "Aquário";

                    break;
            }

            Console.WriteLine("Seu signo é: " + signo);
        }

    }
}
