using System;

class MainClass{
  public static void Main(String[] args){
    String[] primeira = Console.ReadLine().Split(' ');
    String[] segunda = Console.ReadLine().Split(' ');
    int L = int.Parse(primeira[0]);
    int D = int.Parse(primeira[1]);
    int K = int.Parse(segunda[0]);
    int P = int.Parse(segunda[1]);
    int custo = L/D*P+L*K;
    Console.WriteLine(custo);
    
  }
}