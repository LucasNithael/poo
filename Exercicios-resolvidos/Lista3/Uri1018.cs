using System;

class MainClass{
  public static void Main(){
    int valor = int.Parse(Console.ReadLine());
    int n100 = valor/100;
    int n50 = (valor%100)/50;
    int n20 = (valor%100%50)/20;
    int n10 = (valor%100%50%20)/10;
    int n5 = (valor%100%50%20%10)/5;
    int n2 = (valor%100%50%20%10%5)/2;
    int n1 = (valor%100%50%20%10%5%2);
    Console.WriteLine($"{n100} nota(s) de R$ 100,00");
    Console.WriteLine($"{n50} nota(s) de R$ 50,00");
    Console.WriteLine($"{n20} nota(s) de R$ 20,00");
    Console.WriteLine($"{n10} nota(s) de R$ 10,00");
    Console.WriteLine($"{n5} nota(s) de R$ 5,00");
    Console.WriteLine($"{n2} nota(s) de R$ 2,00");
    Console.WriteLine($"{n1} nota(s) de R$ 1,00");
  }
}