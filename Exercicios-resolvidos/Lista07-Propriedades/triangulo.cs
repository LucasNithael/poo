using System;

class Program{
  public static void Main(){
    //Triangulo x = new Triangulo();
    //x.Base = 10;
    //x.Altura = 20;
    Triangulo x = new Triangulo{Base = 10, Altura = 20};
    Console.WriteLine(x.Base);
    Console.WriteLine(x.Altura);
    Console.WriteLine(x.Area);
  }
}

class Triangulo{
  private double b, h;
  public double Base{
    get => b; set => b = value > 0 ? value: 0;
    //get {return b;}
    //set {if(value > 0) b = value;}
  }
  public double Altura{
    get => h; set => h = value > 0 ? value: 0;
    //get {return h;}
    //set {if(value > 0) h = value;}
  }
  public double Area{
     get => b * h / 2; 
    //get { return b*h / 2; }
  }
}