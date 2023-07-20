namespace Exercicios15 
{
    class Program15 
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor em dólar a ser comprado: ");
            double valorDolar = double.Parse(Console.ReadLine());

            double valorReal = ConversorDeMoeda.ConverterDolarParaReal(valorDolar, cotacao);

            Console.WriteLine($"Valor a ser pago em reais: {valorReal:F2}");

        }
    }
}