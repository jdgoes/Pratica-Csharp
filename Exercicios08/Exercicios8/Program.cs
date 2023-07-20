using People;

namespace Exercicios8
{
    class Program8
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new();
            Pessoa pessoa2 = new();

            pessoa1.nome = "Maria";
            pessoa1.idade = 17;

            pessoa2.nome = "João";
            pessoa2.idade = 16;

            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine("Dados da primeira pessoa:");
                Console.WriteLine($"Nome: {pessoa1.nome}");
                Console.WriteLine($"Idade: {pessoa1.idade}");
                Console.WriteLine("Dados da segunda pessoa:");
                Console.WriteLine($"Nome: {pessoa2.nome}");
                Console.WriteLine($"Idade: {pessoa2.idade}");
                Console.WriteLine($"\nPessoa mais velha: {pessoa1.nome}");
            }
            else
            {
                Console.WriteLine("Dados da primeira pessoa:");
                Console.WriteLine($"Nome: {pessoa1.nome}");
                Console.WriteLine($"Idade: {pessoa1.idade}");
                Console.WriteLine("Dados da segunda pessoa:");
                Console.WriteLine($"Nome: {pessoa2.nome}");
                Console.WriteLine($"Idade: {pessoa2.idade}");
                Console.WriteLine($"\nPessoa mais velha: {pessoa2.nome}");
            }

        }
    }
}