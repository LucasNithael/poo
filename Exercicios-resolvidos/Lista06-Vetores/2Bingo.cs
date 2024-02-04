using System;

class MainClass{
  public static void Main(){
  Bingo x = new Bingo();
  x.Iniciar(5);
  Console.WriteLine(x.Proximo());
  Console.WriteLine(x.Proximo());
  Console.WriteLine(x.Proximo());
  Console.WriteLine(x.Proximo());
  Console.WriteLine(x.Proximo());
  Console.WriteLine(x.Proximo());
    
  Console.Write("Sorteadas: {");
  foreach(int i in x.Sorteadas())
    Console.Write($"{i} ");
  Console.Write("}");
  }
}

class Bingo{
  private int numBola;
  private int[] sorteado;
  private int k=0;
  public void Iniciar(int numBola){
    this.numBola = numBola;
    sorteado = new int[numBola];
  }
  public int Proximo(){
    if(k==numBola) return -1;
    Random x = new Random();          //tem como gerar valores sem ser repetidos
    int bola = x.Next(numBola);
    sorteado[k] = bola;
    k++;
    return bola;
  }
  public int[] Sorteadas(){
    return sorteado;
  }
}