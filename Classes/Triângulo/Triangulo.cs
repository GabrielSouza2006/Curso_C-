using System;

class triangulo{
    public double x1;
    public double x2;
    public double x3;


    public double Area(){
        double p = (x1 + x2 + x3) / 2.0;
        double raiz = Math.Sqrt(p * (p - x1) * (p - x2) * (p - x3));
        return raiz;
    }
}