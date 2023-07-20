using System;

namespace Exercicio5
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o código da peça 1: ");
            int codigoPeca1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de peças 1: ");
            int quantidadePeca1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor unitário da peça: ");
            double valorUnitarioDaPeca1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o código da peça 2: ");
            int codigoPeca2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de peças 2: ");
            int quantidadePeca2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor unitário da peça: ");
            double valorUnitarioDaPeca2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"O valor da peça 1 é: R$ {quantidadePeca1 * valorUnitarioDaPeca1}\n" +
                $"O valor da peça 2 é: R$ {quantidadePeca2 * valorUnitarioDaPeca2}\n" +
                $"Somando esses dois valores, o preço total fica: R$ {(quantidadePeca1 * valorUnitarioDaPeca1) + 
                (quantidadePeca2 * valorUnitarioDaPeca2)}");
        }
    }
}