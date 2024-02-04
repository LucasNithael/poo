using System;

class Program{
  public static void Main(){
    Frete a = new FreteTerrestre(100, 10);
    Frete b = new FreteAereo(100, 10, 50);
    Console.WriteLine(a.GetFrete());
    Console.WriteLine(b.GetFrete());
  }
}

abstract class Frete{
  protected double distancia;
  protected double peso;
  public Frete(double d, double p){
    this.distancia = d;
    this.peso = p;
  }
  public abstract decimal GetFrete();
  public override string ToString(){
    return $"{distancia}Km, {peso}Kg";
  }
}

class FreteTerrestre : Frete{
  public FreteTerrestre(double d, double p) : base(d,p) {}
  public override decimal GetFrete(){
    decimal frete = (decimal)distancia*(decimal)peso*(decimal)0.01; 
    return frete;
  }
}

class FreteAereo : Frete{
  private decimal seguro;
  public FreteAereo(double d, double p, decimal s) : base(d,p){
    this.seguro = s;
  }
  public override decimal GetFrete(){
    decimal frete = (decimal)distancia*(decimal)peso*(decimal)0.01; 
    return 2*frete+(seguro*(decimal)0.01);
  }
}