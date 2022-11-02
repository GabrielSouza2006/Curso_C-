class Program{
    private static void Main(string[] args){
        
        Retangulo ret = new Retangulo();

        System.Console.Write("Digite o valor da altura: ");
        ret.altura = double.Parse(Console.ReadLine());
        System.Console.Write("Digite o valor da Largura: ");
        ret.largura = double.Parse(Console.ReadLine());

        System.Console.WriteLine();
        System.Console.WriteLine(ret.ToString());

    }
}