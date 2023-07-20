using Exercicios12;

namespace Exercicios12
{
    class Program12
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new();

            Console.Write("Digite a largura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine());

            Console.Write("Digite à altura do retângulo: ");
            retangulo.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"{retangulo}");
        }
    }
}