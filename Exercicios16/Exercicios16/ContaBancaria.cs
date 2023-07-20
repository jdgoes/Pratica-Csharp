namespace Exercicios16
{
    class ContaBancaria
    {
        private int _numeroConta;
        private string _nomeTitular;
        private double _saldo;

        public ContaBancaria(int numeroConta, string nomeTitular)
        {
            _numeroConta = numeroConta;
            _nomeTitular = nomeTitular;
        }

        public ContaBancaria(int numeroConta, string nomeTitular, double depositoInicial) : this (numeroConta, nomeTitular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double valor) { _saldo += valor; }

        public void Saque(double valor)
        {
            _saldo -= valor + 5.0; 

            if (_saldo < 0.0)
            {
                Console.WriteLine("Saldo insuficiente. Será cobrado um valor adicional de R$ 5.00.");
            }
        }

        public override string ToString()
        {
            return $"Conta: {_numeroConta}, Titular: {_nomeTitular}, Saldo: R$ {_saldo:F2}";
        }

    }
}