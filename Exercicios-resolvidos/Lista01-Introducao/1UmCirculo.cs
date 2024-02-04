using System;

class Program{
  public static void Main(){
  Circulo x = new Circulo();
  x.r = 1;
  Console.WriteLine(x.CalcArea());
  Console.WriteLine(x.CalcCircunferencia());  
  }
}

class Circulo{
  public double r;
  public  double CalcArea(){
    double area = r*r*3.15;
    return area;
  }
  public  double CalcCircunferencia(){
    double Circunferencia = 2*r*3.15;
    return Circunferencia;
  }
}