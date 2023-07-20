/*Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
casas decimais conforme exemplos 
Fórmula da área: area = π . raio2
Considere o valor de π = 3.14159 */

using System;

namespace Exercicio2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do raio: ");
            double calculandoArea = double.Parse(Console.ReadLine());

            Console.WriteLine($"O valor dessa área é igual à: {Math.PI * (calculandoArea * calculandoArea):F4}");
        }
    }
}
