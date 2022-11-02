using System.Globalization;
class Retangulo{
    
    public double altura;
    public double largura;

    public double Area(){
        return altura * largura;
    }

    public double Perimetro(){
        return altura + altura + largura + largura;
    }

    public double diagonal(){
        return Math.Sqrt(altura * altura + largura * largura);
        
    }

    public override string ToString(){
        return "A área do retângulo é " + Area().ToString("F2", CultureInfo.InvariantCulture) + ", o perímetro é " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) + ", e a diagonal é " + diagonal().ToString("F2", CultureInfo.InvariantCulture) + ".";
    }

}