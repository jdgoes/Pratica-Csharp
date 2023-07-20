/* A dona de um pensionato possui dez quartos para alugar para estudantes,
sendo esses quartos identificados pelos números 0 a 9.
Quando um estudante deseja alugar um quarto, deve-se registrar o nome
e email deste estudante.
Fazer um programa que inicie com todos os dez quartos vazios, e depois
leia uma quantidade N representando o número de estudantes que vão
alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
N estudantes. Para cada registro de aluguel, informar o nome e email do
estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
um relatório de todas ocupações do pensionato, por ordem de quarto,
conforme exemplo.*/

using Exercicios17;
class Pensionato
{
    static void Main(string[] args)
    {
        Estudante[] quartos = new Estudante[10];

        Console.Write("Digite a quantidade de estudantes que vão alugar quartos (1 a 10): ");
        int quantidadeEstudantes = int.Parse(Console.ReadLine());

        for (int count = 0; count < quantidadeEstudantes; count++)
        {
            Console.WriteLine($"\nAluguel {count + 1}:");

            Console.Write("Nome do estudante: ");
            string nome = Console.ReadLine();

            Console.Write("Email do estudante: ");
            string email = Console.ReadLine();

            int numeroQuarto;

            do
            {
                Console.Write("Número do quarto (0 a 9): ");
                numeroQuarto = int.Parse(Console.ReadLine());

                if (quartos[numeroQuarto] != null)
                {
                    Console.WriteLine("Quarto já está ocupado. Escolha outro quarto.");
                }
            } while (quartos[numeroQuarto] != null);

            quartos[numeroQuarto] = new Estudante(nome, email);
        }


        Console.WriteLine("\nRelatório de ocupações do pensionato:");

        for (int i = 0; i < 10; i++)
        {
            if (quartos[i] != null)
            {
                Console.WriteLine($"Quarto {i}: {quartos[i].Nome}, {quartos[i].Email}");
            }
        }
    }
}