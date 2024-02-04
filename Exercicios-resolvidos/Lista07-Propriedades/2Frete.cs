using System;

class Program{
  public static void Main(){
    Frete x = new Frete{Distancia = 100, Peso = 10};
    Console.WriteLine(x);
    Console.WriteLine("Valor do Frete: " + x.ValorFrete);
    
    
  }
}

class Frete{
  private double distancia;
  private double peso;
  public double Distancia{
    get => distancia; set => distancia = value > 0 ? value: 0;
    
  }
  public double Peso{
    get => peso; set => peso = value > 0 ? value: 0;
  }
  public double ValorFrete{
    get => distancia/peso;
  }
  public override string ToString(){
    return $"Distancia: {distancia} Peso: {peso}";
  }
}
