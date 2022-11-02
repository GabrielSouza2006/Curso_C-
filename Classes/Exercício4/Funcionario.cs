class Employee{

    public string name;
    public double salary;
    public double tax;

    public double SalarioLiquido(){
        return salary - tax; 
    }

    public void AumentarSalario(double porcentagem){
        salary = salary + (salary * porcentagem / 100);
    }

    public override string ToString(){
        return "Funcionário: " + name + ", $" + SalarioLiquido().ToString("F2");
    }
}