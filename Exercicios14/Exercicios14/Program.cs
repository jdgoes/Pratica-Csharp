namespace Exercicios14
{
    class Program14
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a nota do primeiro trimestre: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota do segundo trimestre: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota do terceiro trimestre: ");
            double nota3 = double.Parse(Console.ReadLine());

            Aluno aluno = new Aluno(nome, nota1, nota2, nota3);
            aluno.ExibirResultado();
        }
    }
}