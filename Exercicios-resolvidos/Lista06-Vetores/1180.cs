using System;

class Program{
  public static void Main(){
    int n = int.Parse(Console.ReadLine());
    string[] x = Console.ReadLine().Split();
    int[] v = new int[x.Length];
    for(int i=0; i<x.Length; i++){
      v[i] = int.Parse(x[i]);
    }
    int menor = v[0];
    int indice = 0;
    for(int i=1; i<v.Length; i++){
      if (v[i]<menor){
        menor = v[i];
        indice = i;
      }
    }

    //int[] v = s.Select(int.Parse).ToArray(); 
    //int menor = v.Min();
    //int pos = Array.IndexOf(v, menor);
    
    Console.WriteLine($"Menor valor: {menor}");
    Console.WriteLine($"Posicao: {indice}");
  }
}