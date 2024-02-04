using System;

class MainClass{
  static void Main(){
   string[] a = Console.ReadLine().Split(' ');
   string[] b = Console.ReadLine().Split(' ');
   double x1 = double.Parse(a[0]);
   double y1 = double.Parse(a[1]);
   double x2 = double.Parse(b[0]);
   double y2 = double.Parse(b[1]);
   double c = x2 - x1;
   double d = y2 - y1;
   double dist = Math.Sqrt(Math.Pow(c, 2)+(Math.Pow(d, 2)));
   Console.WriteLine($"{dist:0.0000}");
  }
}