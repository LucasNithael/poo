using System;
using System.Collections.Generic;

class MainClass{
  public static void Main(){
    Conversor x = new Conversor(32);
    Console.Write(x.Binario());
  }
}

class Conversor{
  private int num;
  private  Stack<int> p = new Stack<int>();
  public Conversor(int num){SetNum(num);}
  public void SetNum(int num){this.num=num;}
  public int GetNum(){return num;}
  public string Binario(){
    int n;
    while(num!=0){
      n=num%2;
      p.Push(n);
      num/=2;
    }
    string s = "";
    while(p.Count>0)
      s += p.Pop().ToString();
    return s;
  }
  //public override string ToString(){return $"{num} = " + Binario(num);}
}