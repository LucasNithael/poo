using System;

class Program{
  public static void Main(){
    Retangulo x = new Retangulo();
    x.SetBase(-10);
    x.SetAltura(20);
    Console.WriteLine(x.CalcArea());
    Console.WriteLine(x);
  }
}

class Retangulo {
  private double b, h;
  public void SetBase(double v) {
    if (v > 0) b = v;
    else
      throw new ArgumentOutOfRangeException("Base inválida");
  }
  public double GetBase() {
    return b;
  }
  public void SetAltura(double v) {
    if (v > 0) h = v;
    else 
      throw new ArgumentOutOfRangeException("Altura inválida");
  }
  public double GetAltura() {
    return h;
  }
  public double CalcArea() {
    double area = b * h;
    return area;
  }
  public override string ToString() {
    return $"Base = {b}, Altura = {h}";
  }
}