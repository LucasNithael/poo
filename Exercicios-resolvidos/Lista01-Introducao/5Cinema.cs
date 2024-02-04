using System;

class Program{
  public static void Main(){
    Ingresso x = new Ingresso();
    x.dia = "seg";
    x.hora = 18;
    Console.WriteLine(x.valorIngresso());
  }
}

class Ingresso{
  public string dia;
  public int hora;
  public double valorIngresso(){
    double preco = 0;
    this.dia = dia.ToUpper();
    if(dia=="SEG" || dia=="TER" || dia=="QUI"){
      preco = 16.00;
      if(hora>17 && hora<24){
        preco = preco*1.5;
      }
      return preco;
    }
    if(dia=="QUA"){
      preco = 8.00;
    }
    if(dia=="SEX" || dia=="SAB" || dia=="DOM"){
      preco = 20.00;
      if(hora>17 && hora<24){
        preco = preco*1.5;
      }
    }
    return preco;  
  }
  
}