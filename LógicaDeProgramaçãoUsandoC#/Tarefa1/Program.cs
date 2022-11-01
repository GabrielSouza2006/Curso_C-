class Program{
    private static void Main(string[] args){

        string prod1 = "computador";
        string prod2 = "Mesa de escritório";

        byte idade = 30; 
        int codigo = 123;
        char genero = 'M';

        double preco1 = 2100.0;
        double preco2 = 650.50;
        double medida = 53.234567;

        Console.WriteLine("Produtos: ");
        Console.WriteLine($"{prod1}, cujo o preço é $ {preco1}");
        Console.WriteLine($"{prod2}, cujo o preço é $ {preco2}");
        Console.WriteLine();
        Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
        Console.WriteLine();
        Console.WriteLine($"Medida com oito casas decimais: {medida.ToString("F8")}");
        Console.WriteLine($"Arredondando: {medida.ToString("F3")}");
        
    }
}