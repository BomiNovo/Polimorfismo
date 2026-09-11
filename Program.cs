namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometria geometria = new Geometria();

            double areaQuadrado = geometria.CalcularArea(5);

            double areaRetangulo = geometria.CalcularArea(10, 4);

            double areaCirculo = geometria.CalcularArea(3, true);

            Console.WriteLine("Área de quadrado: " + areaQuadrado);
            Console.WriteLine("Área de retângulo: " + areaRetangulo);
            Console.WriteLine("Área de círculo: " + areaCirculo);
        }
    }
}
