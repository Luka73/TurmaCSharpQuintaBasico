using System;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU : " +
                "\n 1 - Adicionar " +
                "\n 2 - Excluir " +
                "\n 3 - Atualizar " +
                "\n 4 - Inserir ");

            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1: 
                    Console.WriteLine("Adicionando um item!");
                    break;
                case 2:
                    Console.WriteLine("Excluindo um item");
                    break;
                case 3:
                    Console.WriteLine("Atualizando um item");
                    break;
                case 4:
                    Console.WriteLine("Digite o valor que você quer doar: ");
                    double valor = double.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Opcao invalida");
                    break;
            }

            if(opcao >= 10 && opcao <= 999) //ranges --> intervalos
            {
                Console.WriteLine("Adicionando um item!");
            } else if(opcao == 2)
            {
                Console.WriteLine("Excluindo um item");
            } else if(opcao == 3)
            {
                Console.WriteLine("Atualizando um item");
            } else
            {
                Console.WriteLine("Opcao invalida");
            }
        }
    }
}
