/* Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma 
mensagem explicativa, conforme exemplos. */

using System;

namespace Exercicio1
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int primeiraEntrada = int.Parse(Console.ReadLine());

            Console.Write("Digite um outro valor: ");
            int segundaEntrada = int.Parse(Console.ReadLine());

            Console.WriteLine($"A soma desses dois valores é igual a: {primeiraEntrada + segundaEntrada}");

        }
    }
}