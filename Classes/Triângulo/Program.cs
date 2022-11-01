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

    double p = (x.x1 + x.x2 + x.x3) / 2.0;
    double areaX = Math.Sqrt(p * (p - x.x1) * (p - x.x2) * (p - x.x3)); 

    p = (y.x1 + y.x2 + y.x3) / 2.0;
    double areaY = Math.Sqrt(p * (p - y.x1) * (p - y.x2) * (p - y.x3)); 

    System.Console.WriteLine($"A área do 1º Triângulo é {areaX.ToString("F2")}, a do 2º é {areaY.ToString("F2")}");
    }
}