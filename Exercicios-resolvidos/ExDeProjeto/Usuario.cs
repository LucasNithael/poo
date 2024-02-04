using System;


class Usuario{
  public int Id{get; set;}
  public string Nome{get; set;}
  public string Senha{get; set;}
  public bool Admin{get; set;}
  public override string ToString(){
   return $"{Id} - {Nome}";  
  }
}