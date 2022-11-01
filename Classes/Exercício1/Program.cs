class Program
{
    private static void Main(string[] args)
    {
        
        People peo1 = new People();
        People peo2 = new People();

        System.Console.Write("Digite o nome: ");
        peo1.name = Console.ReadLine();
        System.Console.Write("Digite a idade: ");
        peo1.age = int.Parse(Console.ReadLine());

        System.Console.WriteLine();
        System.Console.Write("Digite o nome: ");
        peo2.name = Console.ReadLine();
        System.Console.Write("Digite a idade: ");
        peo2.age = int.Parse(Console.ReadLine());

        if(peo1.age > peo2.age){
            System.Console.WriteLine($"A pessoa mais velha é: {peo1.name}");
        }
        else{
            System.Console.WriteLine($"A pessoa mais velha é: {peo2.name}");
        }
    }
}