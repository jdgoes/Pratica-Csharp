using Exercicios7;
using System;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle x, y;

            x = new Triangle();
            y = new Triangle();

            Console.WriteLine("Entre com as medidas do triângulo X:");

            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine($"Área de X = {areaX:F4}");
            Console.WriteLine($"Área de Y = {areaY:F4}");

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else if (areaX < areaY)
            {
                Console.WriteLine("Maior área: Y");
            } 
            else
            {
                Console.WriteLine("Valores iguais.");
            }
        }
    }
}
