using System;

class Program{
  public static void Main(){
    Ingresso x = new Ingresso();
    x.SetDia("qll");
    x.SetHora(14);
    Console.WriteLine("valor do ingresso: " + x.valorIngresso());
  }
}

class Ingresso{
  private string dia = " ";
  private int hora=-1;
  public void SetDia(string dia){
    dia = dia.ToUpper();
    if(dia=="SEG" || dia=="TER" || dia=="QUA" || dia=="QUI" || dia=="SEX" || dia=="SAB" || dia=="DOM"){
    this.dia = dia;
    }
  }
  public void SetHora(int hora){
    if(hora>=00 && hora<=24) this.hora = hora;
  }
  public string GetDia(){
    return dia;
  }
  public int GetHora(){
    return hora;
  }
  public double valorIngresso(){
    double preco = 0;
    this.dia = dia.ToUpper();
    if(dia=="SEG" || dia=="TER" || dia=="QUI"){
      preco = 16.00;
      if(hora>17 && hora<24 || hora==00){
        preco = preco*1.5;
      }
      return preco;
    }
    if(dia=="QUA"){
      preco = 8.00;
    }
    if(dia=="SEX" || dia=="SAB" || dia=="DOM"){
      preco = 20.00;
      if(hora>17 && hora<24 || hora==00){
        preco = preco*1.5;
      }
    }
    return preco;  
  }
  
}