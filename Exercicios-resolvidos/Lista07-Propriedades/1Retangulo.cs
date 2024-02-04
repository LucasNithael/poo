using System;

class Program{
  public static void Main(){
    Retangulo x = new Retangulo();
    x.Base = 4;
    x.Altura = 3;
    Console.WriteLine(x);
    Console.WriteLine("Area: " + x.Area);
    Console.WriteLine("Diagonal: " + x.Diagonal);
  }
}

class Retangulo{
  private double b;
  private double h;
  public double Base{
    get => b; set => b = value > 0 ? value: 0;
  }
  public double Altura{
    get => h; set => h = value > 0 ? value: 0;
  }
  public double Area{
    get => b*h;
  }
  public double Diagonal{
    get => Math.Sqrt(b*b + h*h);
  }
  public override string ToString(){
    return $"Base: {b} Altura: {h}";
  }
}