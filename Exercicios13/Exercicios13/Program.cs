namespace Exercicios13 
{
    class Program13 
    {
        static void Main(string[] args) 
        {   
            Funcionario funcionario = new();

            Console.Write("Digite o nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Digite o salário bruto do funcionário: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Digite o imposto em R$ do funcionário: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do Funcionário: {funcionario}");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());
            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine($"Dados do Funcionário atualizado: {funcionario}");
        }
    }
}