using System;

class MainClass{
  public static void Main(){
    ISequencia x = new PA(3, 2);
    //ISequencia x = new Fibonacci();
    Console.WriteLine(x.Iniciar());
    Console.WriteLine(x.Proximo());
    Console.WriteLine(x.Proximo());
    Console.WriteLine(x.Proximo());
    Console.WriteLine(x.Proximo());
    Console.WriteLine(x.Proximo());
    Console.WriteLine(x.Proximo());
    Console.WriteLine(x.Proximo());
    
  }
}

interface ISequencia{
  int Iniciar();
  int Proximo();
}

class PA : ISequencia{
  private int primeiroElemento;
  private int razao;
  public PA(int p, int r){ 
    this.primeiroElemento=p; 
    this.razao = r;
  }
  public int Iniciar(){
    return primeiroElemento;
  }
  public int Proximo(){
    primeiroElemento += razao;
    return primeiroElemento;
  }
}

class Fibonacci : ISequencia{
  private int primeiroElemento=0;
  private int segundoElemento=1;
  public int Iniciar(){
    return primeiroElemento;
  }
  public int Proximo(){
    int k = segundoElemento;
     segundoElemento += primeiroElemento;
    primeiroElemento = k;
    return segundoElemento;
  }
}
