using System;

class Program{
  public static void Main(){
    Frete x = new Frete(10, 2);
    Console.WriteLine(x);
    x.SetDistancia(4);
    x.SetPeso(3);
    Console.WriteLine(x.CalcFrete());
    Console.WriteLine(x);
  }
}

class Frete{
  private double distancia=0;
  private double peso=0;
  public Frete(double distancia, double peso){
    if(distancia>0) this.distancia = distancia;
    if(peso>0) this.peso = peso;
  }
  public void SetDistancia(double distancia){
     if(distancia>0) this.distancia = distancia;
  }
  public void SetPeso(double peso){
     if(peso>0) this.peso = peso;
  }
  public double GetDistancia(double distancia){
    return distancia;
  }
  public double GetPeso(double peso){
    return peso;
  }
  public double CalcFrete(){
    return distancia*peso;
  }
  public override string ToString(){
    return $"Distancia = {distancia}  Peso = {peso}";
  }
}

//Nesse exemplo o comando pede que ToSring return os valores iniciais, são os valores que foram definidos no construtor ou os que foram modificados com os métodos de acesso