/*Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e 
mostre: 
a) a área do triângulo retângulo que tem A por base e C por altura. 
b) a área do círculo de raio C. (pi = 3.14159) 
c) a área do trapézio que tem A e B por bases e C por altura. 
d) a área do quadrado que tem lado B. 
e) a área do retângulo que tem lados A e B*/

using System;

namespace Exericio6
{
    class Program6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A: ");
            double valorDeA = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            double valorDeB = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C: ");
            double valorDeC = double.Parse(Console.ReadLine());

            Console.WriteLine($"TRIÂNGULO: {(valorDeA * valorDeC) / 2:F3}");
            Console.WriteLine($"CIRCULO: {Math.PI * Math.Pow(valorDeC, 2):F3}");
            Console.WriteLine($"TRAPEZIO: {((valorDeA + valorDeB) * valorDeC) / 2:F3}");
            Console.WriteLine($"QUADRADO: {Math.Pow(valorDeB, 2):F3}");
            Console.WriteLine($"RETANGULO: {valorDeA * valorDeB:F3}");
        }
    }
}