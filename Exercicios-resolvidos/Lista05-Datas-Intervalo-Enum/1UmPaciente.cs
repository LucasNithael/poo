using System;
using System.Globalization;
using System.Threading;

class Program{
  public static void Main(){
    CultureInfo ci = new CultureInfo("pt-BR");
    Thread.CurrentThread.CurrentCulture = ci;
    Paciente x = new Paciente("Lucas", "705.415.194-17", 
                              "8499152-5865", DateTime.Parse("12/06/2000"));
    Console.WriteLine(x.Idade());
    Console.WriteLine(x);
    
  }
}

class Paciente{
  private string nome;
  private string cpf;
  private string telefone;
  private DateTime nascimento;
  public Paciente(string n, string c, string t, DateTime nasc){
    this.nome = n;
    this.cpf = c;
    this.telefone = t;
    this.nascimento = nasc;
  }
  public string Idade(){
    
    return $"Ano: {DateTime.Today.Year - nascimento.Year}\nMês: {DateTime.Today.Month - nascimento.Month}";
  }
  public override string ToString(){
    return $"Nome: {nome}\nCpf: {cpf}\nTelefone: {telefone}\nNascimento: {nascimento}";
  }
}