using System;

class Program{
  public static void Main(){
    Retangulo x = new Retangulo(10, 2);
    x.SetBase();
    x.SetAltura();
    Console.WriteLine(x.CalcArea());
    Console.WriteLine(x.CalcDiagonal());
    Console.WriteLine(Retangulo);
    Console.WriteLine(x.ToString()); 
  }
}

class Retangulo{
  private double b = 0;
  private double h = 0;
  public Retangulo(){ }
  public Retangulo (double b, double h){
    if(b>0) this.b=b;
    if(h>0) this.h=h;
  }
  public void SetBase(double b){
    if(b>0) this.b = b;
  }
  public void SetAltura(double h){
    if(h>0) this.h = h;
  }
  public double GetBase(){
    return b;
  }
  public double GetAltura(){
    return h;
  }
  public double CalcArea(){
    return b*h;
  }
  public double CalcDiagonal(){
    return Math.Sqrt(b*b + h*h);
  }
  public override string ToString(){
    return $"Base = {b} Altura = {h}";
  }
}