using Exercicios11;
using System;

namespace Exercicios11
{
    class Program11
    {
        static void Main(string[] args)
        {
            Produto produto = new();    

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome do produto: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço do produto: ");
            produto.Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade do produto: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {produto}");

            Console.Write("\nDigite a quantidade de produtos a serem adicionados ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qte);

            Console.WriteLine($"\nDados do produto atualizado: {produto}");

            Console.Write("\nDigite a quantidade de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qte);

            Console.WriteLine($"\nDados do produto atualizado: {produto}");
        }
    }
}