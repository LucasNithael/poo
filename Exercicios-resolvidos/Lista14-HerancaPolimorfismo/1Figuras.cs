using System;

class MainClass{
  public static void Main(){
    Retangulo r = new Retangulo(4, 3);
    Console.WriteLine(r);
    Quadrado q = new Quadrado(5);
    Console.WriteLine(q);
    Console.WriteLine(r.CalcArea());
    Console.WriteLine(r.CalcDiagonal());
    Console.WriteLine(q.CalcArea()); 
  }
}

class Retangulo{
  private double b = 0;
  private double h = 0;
  public Retangulo(double b, double h){
    this.b = b; this.h = h;
  }
  public double GetBase(){
    return b;
  }
  public double GetAltura(){
    return h;
  }
  public virtual double CalcArea(){
    return b*h;
  }
  public virtual double CalcDiagonal(){
    return Math.Sqrt(b*b + h*h);
  }
  public override string ToString(){
    return $"Base: {b} - Altura: {h}";
  }
}

class Quadrado: Retangulo{
  public Quadrado(double l) : base(l, l){}
  public override string ToString(){
    return $"Lados: {GetBase()}";
  }
}