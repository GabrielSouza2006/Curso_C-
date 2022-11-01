
class Program{
    private static void Main(string[] args){

        Employee emp1 = new Employee();
        Employee emp2 = new Employee();

        System.Console.Write("Digite o nome: ");
        emp1.name = Console.ReadLine();
        System.Console.Write("Digite o salário: ");
        emp1.salary = double.Parse(Console.ReadLine());
        
        System.Console.WriteLine();
        System.Console.Write("Digite o nome: ");
        emp2.name = Console.ReadLine();
        System.Console.Write("Digite o salário: ");
        emp2.salary = double.Parse(Console.ReadLine());

        double mediaSalario = (emp1.salary + emp2.salary) / 2;

        System.Console.WriteLine();
        System.Console.WriteLine($"A média dos salários é: ${mediaSalario.ToString("F2")}");
    }
}