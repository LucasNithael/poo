using System;

class MainClass{
  public static void Main(){
  string[] n = Console.ReadLine().Split(' ');
  int a = int.Parse(n[0]);
  int b = int.Parse(n[1]);
  int c = int.Parse(n[2]);
  int d = int.Parse(n[3]);
  if((b > c && d > a) && (c+d) > (a+b) && c>0 && d>0 && (a%2==0))
    Console.WriteLine("Valores aceitos");
  else Console.WriteLine("Valores nao aceitos");
  }
}