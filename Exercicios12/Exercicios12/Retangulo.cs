namespace Exercicios12
{
   class Retangulo
    {
        public double Largura;
        public double Altura;
        public double Area() { return Largura * Altura; }
        public double Perimetro() {return 2 * (Largura + Altura); }
        public double Diagonal() { return Math.Sqrt(Largura * Largura + Altura * Altura); }

        public override string ToString()
        {
            return $"ÁREA = {Area():F4} \n" +
                $"PERÍMETRO = {Perimetro():F4} \n" +
                $"DIAGONAL = {Diagonal():F4}";
        }
    }
}
 