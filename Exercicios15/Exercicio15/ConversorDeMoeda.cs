namespace Exercicios15
{
    class ConversorDeMoeda
    {
        private static double Iof = 0.00057;

        public static double ConverterDolarParaReal(double valorDolar, double cotacao)
        {
            double valorReal = valorDolar * cotacao;
            double valorComIOF = valorReal + (valorReal * Iof);
            return valorComIOF;
        }
    }
}
