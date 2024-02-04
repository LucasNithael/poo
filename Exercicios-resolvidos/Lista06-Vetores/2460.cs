using System;

class Program{
  public static void Main(){
    int n = int.Parse(Console.ReadLine());
    string[] x = Console.ReadLine().Split();
    int[] v = new int[n];
    for(int i=0; i<n; i++)
     v[i] = int.Parse(x[i]);
    
    int m = int.Parse(Console.ReadLine());
    string[] z = Console.ReadLine().Split();
    int[] y = new int[m];
    for(int i=0; i<m; i++){
      y[i] = int.Parse(z[i]);
    }

    for(int i=0; i<n; i++){
      for(int j=0; j<m; j++){
        if(v[i]==y[j]){
          v[i] = 0;
        }
      }
    Console.Write($"{v[i]} ");
    }

  
  
  }
}