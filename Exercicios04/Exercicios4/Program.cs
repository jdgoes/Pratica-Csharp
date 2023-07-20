/*Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas 
decimais*/

using System;

namespace Exercicio4
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu número ? ");
            int numeroFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas horas você trabalha por mês ? ");
            double horasMensais = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da sua hora em reais ? ");
            double valorDaHoraTrabalhada = double.Parse(Console.ReadLine());

            Console.WriteLine($"Olá funcionário número {numeroFuncionario} o seu salário mensal é de R$ {horasMensais * valorDaHoraTrabalhada:F2} reais. ");
        }
    }
}