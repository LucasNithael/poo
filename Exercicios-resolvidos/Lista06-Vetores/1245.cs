using System;

class Program{
  public static void Main (string[] args) {
    int n = int.Parse(Console.ReadLine());
    string[,] m = new string[n,2];
    for(int i=0; i<n; i++){
      for(int j=1; j<=2; j++){
        m[i,j] = Console.ReadLine().Split();
      }
      Console.Write("{0,3}", m[]);
      Console.WriteLine();
    }
    

  
  }
}