using System;

class Program{
  public static void Main(){
  Viagem x = new Viagem();
  x.distancia = 200;
  x.hora = 2;
  Console.WriteLine(x.VelocidadeMedia() + "km/h");
  
  }
}

class Viagem{
  public double distancia, hora;
  public double VelocidadeMedia(){
    double vm = distancia/hora;
    return vm;
  }
}