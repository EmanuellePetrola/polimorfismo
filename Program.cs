using Polimorfismo;

class Program
{
    static void Main(string[] args)
    {
        Geometria geometria = new Geometria();

        double areaQuadrado = geometria.CalcularArea(8);

        double areaRetangulo = geometria.CalcularArea(42, 6);

        double areaCirculo = geometria.CalcularArea(3, true);

        Console.WriteLine($"Área do quadrado: {areaQuadrado:F2}");
        Console.WriteLine($"Área do retângulo: {areaRetangulo:F2}");
        Console.WriteLine($"Área do círculo: {areaCirculo:F2}");
    }
}






