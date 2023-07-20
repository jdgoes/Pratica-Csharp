namespace Exercicios14
{
    class Aluno
    {
        private string nome;
        private double nota1;
        private double nota2;
        private double nota3;

        public Aluno(string nome, double nota1, double nota2, double nota3)
        {
            this.nome = nome;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

        public void ExibirResultado()
        {
            double notaFinal = nota1 + nota2 + nota3;
            Console.WriteLine($"Nota final do aluno {nome}: {notaFinal}");

            if (notaFinal >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                double pontosFaltantes = 60 - notaFinal;
                Console.WriteLine($"REPROVADO. Faltam {pontosFaltantes} pontos para a aprovação.");
            }
        }
    }
}

 