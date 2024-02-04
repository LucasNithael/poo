using System;

class Program{
  public static void Main(){
    Circulo x = new Circulo();
    x.SetRaio(3);
    Console.WriteLine("Area: " + x.CalcArea());
    Console.WriteLine("Circunferência: " + x.CalcCircunferencia());

    Circulo y = new Circulo();
    y.SetRaio(-3);
    Console.WriteLine("Area: " + y.CalcArea());
    Console.WriteLine("Circunferência: " + y.CalcCircunferencia());


    
  }
}



class Circulo{
  private double raio;
  public void SetRaio(double raio){
    if(raio > 0) this.raio = raio;
  }
  public double GetRaio(){
    return raio;
  }
  public  double CalcArea(){
    double area = raio*raio*3.15;
    return area;
  }
  public  double CalcCircunferencia(){
    double Circunferencia = 2*raio*3.15;
    return Circunferencia;
  }
}