using System;

class Program{
  public static void Main(){
    Conversor x = new Conversor(16);
    Console.WriteLine(x.Binario() + "\n" + x);
  }
}

class Conversor{
  private int num;
  public Conversor(int num){
    if(num>0) this.num = num;
  }
  public void SetNum(int num){
    if(num>0) this.num = num;
  }
  public int GetNum(){
    return num;
  }
  public string Binario(){
  return Convert.ToString(num, 2);
  }
  public override string ToString(){
    return "Decimal = " + num + " Binario = " + Binario();
  }
}