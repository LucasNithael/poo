using System;

class Program{
  public static void Main(){
    Viagem x = new Viagem();
    x.SetDistancia(100);
    x.SetTempo(2);
    Console.WriteLine(x.VelocidadeMedia());

    Viagem y = new Viagem();
    y.SetDistancia(-100);
    y.SetTempo(-2);
    Console.WriteLine(y.VelocidadeMedia());
  }
}

class Viagem{
  private double distancia=0;
  private double tempo=1;
  public void SetDistancia(double distancia){
    if(distancia>0) this.distancia = distancia;
  }
  public void SetTempo(double tempo){
    if(tempo>0) this.tempo = tempo;
  }
  public double GetDistancia(){
    return distancia;
  }
  public double GetTempo(){
    return tempo;
  }
  public double VelocidadeMedia(){
    double vm = distancia/tempo;
    return vm;
  }
}