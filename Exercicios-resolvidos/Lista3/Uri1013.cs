using System;

class MainClass{
  static void Main(){
    string[] num = Console.ReadLine().Split(' ');
    int a = int.Parse(num[0]);
    int b = int.Parse(num[1]);
    int c = int.Parse(num[2]);
    int maior = (a+b+Math.Abs(a-b))/2; 
    maior = (maior+c+Math.Abs(maior-c))/2;
    Console.WriteLine($"{maior} eh o maior");
  }
}