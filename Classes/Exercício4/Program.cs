class Program{

    public static void Main(String[] args){

        Employee func = new Employee();

        System.Console.WriteLine("Digite o nome, salário e imposto: ");
        func.name = Console.ReadLine();
        func.salary = double.Parse(Console.ReadLine());
        func.tax = double.Parse(Console.ReadLine());

        System.Console.WriteLine();
        System.Console.WriteLine(func);

        System.Console.WriteLine();
        System.Console.Write("Digite a porcentagem: ");
        double por = double.Parse(Console.ReadLine());
        func.AumentarSalario(por);

        System.Console.WriteLine();
        System.Console.WriteLine("Update: ");
        System.Console.WriteLine(func);

    }
}

