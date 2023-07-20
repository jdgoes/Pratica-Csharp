using Pessoa;

namespace Exercicios9
{
    class Program9
    {
        static void Main(string[] args)
        {
            Funcionario func1 = new();
            Funcionario func2 = new();

            func1.nome = "Carlos Silva";
            func1.salario = 6300.00;

            func2.nome = "Ana Marques";
            func2.salario = 6700.00;


            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine($"Nome: {func1.nome}");
            Console.WriteLine($"Salário: R$ {func1.salario:F2}");
            Console.WriteLine("Dados da segunda pessoa:");
            Console.WriteLine($"Nome: {func2.nome}");
            Console.WriteLine($"Salário: R$ {func2.salario:F2}");
            Console.WriteLine($"\nSalário médio: R$ {(func1.salario + func2.salario) / 2:F2}");
        }
    }
}