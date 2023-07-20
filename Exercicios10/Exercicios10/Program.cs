using System;

namespace Exercicios10
{
    class Program10
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

            double areaX = x.AreaDoTriangulo();

            double areaY = y.AreaDoTriangulo();

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