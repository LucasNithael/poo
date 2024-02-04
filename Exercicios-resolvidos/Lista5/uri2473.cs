using System;

class Program{
  public static void Main(){
    string[] n = Console.ReadLine().Split(' ');
    string[] m = Console.ReadLine().Split(' ');
    int qtd=0;
    for(int i=0; i<6; i++){
      for(int j=0; j<6; i++){
        if(n[i]==m[j]){
          qtd++;
        }
      }
    }
    Console.WriteLine(qtd);
  }
}