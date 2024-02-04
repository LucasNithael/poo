using System;

class Program{
  public static void Main(){
    Equacao x = new Equacao(1, 0, 0);
    double a, b, c;
    Console.WriteLine(x.RaizesReais(out a, out b));
  }
}

class Equacao{
  private double a, b, c;
  public Equacao(){ }
  public Equacao(double a, double b, double c){
    if(a!=0){ this.a = a; this.b = b; this.c = c;}
  }
  public void SetABC(double a, double b, double c){
    if(a!=0){ this.a = a; this.b = b; this.c = c;}
  }
  public void GetABC(out double a, out double b, out double c){
    a = this.a;
    b = this.b;
    c = this.c;
  }
  public Tuple<double, double, double> GetABC() {
    return Tuple.Create(a, b, c);
  }
  public double Delta(){
    return b*b-4*a*b;
  }
  public bool RaizesReais(out double x1, out double x2){
    x1 = 0; x2 = 0;
    if(Delta()<0) return false;
    x1 = (-b+Math.Sqrt(Delta()))/(2*a);
    x2 = (-b-Math.Sqrt(Delta()))/(2*a);
    return true;  
  }
}