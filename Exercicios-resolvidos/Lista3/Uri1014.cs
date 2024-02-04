using System;

class MainClass{
  static void Main(){
    int x = int.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
    double consumo = x/y;
    Console.WriteLine($"{consumo:0.000} km/l ");
  }
}