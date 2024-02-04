using System;

class Program{
  public static void Main(){
    Figura3D f1 = new Cubo(2);
    Figura3D f2 = new Esfera(3);
    Console.WriteLine(f1.GetVolume() +"\n"+ f2.GetVolume());
  }
}

abstract class Figura3D{
  public abstract double GetVolume();
}

class Cubo : Figura3D{
  private double lado;
  public Cubo(double l){this.lado = l;}
  public override double GetVolume(){
    return lado*lado*lado;
  }
}

class Esfera : Figura3D{
  private double raio;
  public Esfera(double r){this.raio = r;}
  public override double GetVolume(){
    return (4/3)*Math.PI*(raio*raio*raio);
  }
}