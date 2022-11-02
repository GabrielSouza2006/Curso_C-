class Program{
    private static void Main(string[] args){
        
    triangulo x, y;

    x = new triangulo();
    y = new triangulo();

    System.Console.WriteLine("Digite os valores do 1º triângulo");
    x.x1 = double.Parse(Console.ReadLine());
    x.x2 = double.Parse(Console.ReadLine());
    x.x3 = double.Parse(Console.ReadLine());
    System.Console.WriteLine();

    System.Console.WriteLine("Digite os valores do 2º triângulo");
    y.x1 = double.Parse(Console.ReadLine());
    y.x2 = double.Parse(Console.ReadLine());
    y.x3 = double.Parse(Console.ReadLine());

    System.Console.WriteLine();

    double areaX = x.Area();
    double areaY = y.Area();

    System.Console.WriteLine($"A área do 1º Triângulo é {areaX.ToString("F2")}, a do 2º é {areaY.ToString("F2")}");
    }
}