using System;

class Program{
  public static void Main(){
  string[] n = Console.ReadLine().Split(' ');
  int a = int.Parse(n[0]);
  int b = int.Parse(n[1]);
  int c = int.Parse(n[2]);
  int aux = 0;
  int x = a;
  int y = b; 
  int z = c;
  if(a>b){
    aux = a;
    a = b;
    b = aux;
  }
  if(b>c){
    aux = b;
    b = c;
    c = aux;
  }
  if(a>b){
    aux = a;
    a = b;
    b = aux;
  }
  Console.WriteLine($"{a}\n{b}\n{c}\n\n{x}\n{y}\n{z}");
  
    }
}