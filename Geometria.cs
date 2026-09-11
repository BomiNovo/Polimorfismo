namespace Polimorfismo
{
    class Geometria
    {
        public double CalcularArea( double lado)
        {
            return lado * lado;
        }

        public double CalcularArea(double basee, double altura)
        {
            return basee * altura;
        }

        public double CalcularArea(double raio, bool isCirculo)
        {
            return Math.PI * raio * raio;
        }
    }
}
