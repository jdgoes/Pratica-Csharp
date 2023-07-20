namespace Exercicios13
{
    class Funcionario
    {
        public string? Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() { return SalarioBruto - Imposto; }
        public void AumentarSalario(double porcentagem){ SalarioBruto += (SalarioLiquido() * porcentagem / 100.0); }

        public override string ToString(){ return $"Nome: {Nome}\n" + $"Salário: R$ {SalarioLiquido():F2}"; }
    }
}
