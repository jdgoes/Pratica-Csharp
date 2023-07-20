/* Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto 
de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D)*/
using System;

namespace Exercicio3
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            double valorDeA = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            double valorDeB = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            double valorDeC = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de D: ");
            double valorDeD = double.Parse(Console.ReadLine());

            Console.WriteLine($"A diferença do produto de A e B, pelo produto de C e D é: {valorDeA * valorDeB - valorDeC * valorDeD:F2}");
        }
    }
}