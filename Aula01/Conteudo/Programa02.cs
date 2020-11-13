using System;

namespace Aula01.Conteudo
{
    public class Programa02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pedro"); // --> texto --> string
            Console.WriteLine(15); // --> numero --> int
            Console.WriteLine(15.2); // --> decimal --> double

            Console.WriteLine("Pedro tem " + 15 + " anos."); //concatenar --> juntar!
            Console.WriteLine("Pedro tem 15 anos.");

            Console.WriteLine(12993720291); //numero???
            Console.WriteLine("00929182939");

            Console.WriteLine(15 + 15.2);
            // + --> concatenação (string)
            // + --> soma (numeros)

            Console.WriteLine("15" + 15); //1515
            Console.WriteLine("15" + (15 + 5)); //1520
            Console.WriteLine("15" + (15 - 5));

            Console.WriteLine(15 + 5); //soma
            Console.WriteLine(15 - 5); //substração
            Console.WriteLine(15 * 5); //multiplicação
           
            Console.WriteLine(15 / 5); //divisão --> 3
            Console.WriteLine(15 / 4); //divisão --> 3
            Console.WriteLine(15 / 4.0); //divisão --> 3.75

            //valor literal
            //"Luana";
            //15
            //15.0

            //float, decimal, double (números reias)

            Console.WriteLine(15 % 5); //resto (módulo) --> 0
            Console.WriteLine(15 / 7); //divisão --> 2
            Console.WriteLine(15 % 7); //resto (módulo) --> 1

            Math.Pow(3, 2); // Potência --> 9
            Math.Sqrt(25); // Raiz Quadada --> 5
            Math.Ceiling(5.4); // Arredondamento para cima --> 6
            Math.Floor(5.4); // Arredondamento para baixo --> 5
            Math.Round(5.4); // Arredondamento --> 5
            Math.Abs(-6); // Valor absoluto --> 6

            Console.WriteLine("{0:00.00}", 15.982928302);
            Console.WriteLine("N1: {0:0.000}, N2: {1:0.00}, N3: {2:0.0}", 15.982928302, 67, 32);
            //15.98989 --> 15.98

            string nome1 = "Maria"; // == --> igual / = --> recebe
            string nome2 = "Pedro";
            Console.WriteLine("Meu nome é: " + nome1);
            Console.WriteLine("Meu nome é: " + nome2);

            int n1 = 7;
            int n2 = 3;

            Console.WriteLine("Soma: " + (n1 + n2)); //Soma: 10

            double d1 = 7.2;
            double d2 = 9.1;

            Console.WriteLine("Soma: " + (d1 + d2));
        }
    }
}
