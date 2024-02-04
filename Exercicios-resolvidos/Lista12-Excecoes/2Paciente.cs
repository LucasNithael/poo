using System;

class Program{
  public static void Main(){
    Paciente x = new Paciente("Lucas", DateTime.Parse("08-16-2022"));
    
  }
}

class Paciente{
  private string nome;
  private DateTime nascimento;
  //public string Idade{get{}}
  public Paciente(string nome, DateTime nasc){
    this.nome=nome;
    if(nasc.Year<DateTime.Today.Year)
      this.nascimento=nasc;
    else throw new ArgumentOutOfRangeException("Data invalida");  
  }
  public override string ToString(){
    return $"{nome} {nascimento}";
  }
    
}