using System;

class MainClass{
  public static void Main(){
    Frete f = new Frete(100, 10);
    Console.WriteLine(f);
    Console.WriteLine(f.ValorFrete);
    
    FreteExpresso fx = new FreteExpresso(100, 10, 100);
    Console.WriteLine(fx);
    Console.WriteLine(fx.ValorFrete);
    
  }
}

class Frete{
  protected double distancia;
  protected double peso;
  public double ValorFrete{get{
    return distancia*peso*0.01;
  }}
  public Frete(double d, double p){
    this.distancia=d; this.peso=p;
  }
  public override string ToString(){
    return $"{distancia}Km {peso}Kg";
  }
}

class FreteExpresso: Frete{
  private decimal seguro;
  public FreteExpresso(double d, double p, decimal s) : base(d, p){
    this.seguro = s;
  }
  public double ValorFrete{get{
    double s = Convert.ToDouble(seguro);
    return (distancia*peso*0.01)*2+s*0.01;
  }}
  public override string ToString(){
    return $"{distancia}Kg {peso}Kg - Seguro: {seguro}";
  }
}
