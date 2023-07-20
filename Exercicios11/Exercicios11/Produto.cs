namespace Exercicios11
{
    class Produto
    {
        public string? Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque(){ return Preco * Quantidade; }
        public void AdicionarProdutos(int quantidade) { Quantidade += quantidade; }
        public void RemoverProdutos(int quantidade) { Quantidade -= quantidade; }
        public override string ToString()
        {
            return $"{Nome}, R$ {Preco:F2}, {Quantidade} unidades, total: R$ {ValorTotalEmEstoque():F2}";
        }
    }
}
