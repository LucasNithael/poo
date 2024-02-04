using System;
using System.Collections.Generic;

//Herença: Quando um objeto herda todos atributos e métodos da class base
//Polimorfismo: Quando podemos realizar operações diferentes com os métodos herdados


class Program{
  public static void Main(){
    Funcionario a = new Funcionario("Lucas", 1000);
    Gerente b = new Gerente("Nithael", 1000, 500);
    Gerente c = new Gerente("Mike", 1000, 20);
    object e = new Funcionario("Saul", 900);
    //Console.WriteLine(a);
    //Console.WriteLine(b);
    //b.Premiar(520);
    //Console.WriteLine(b);

    Empresa x = new Empresa();
    x.Inserir(a);
    x.Inserir(b);
    x.Inserir(c);
    x.Inserir(e as Funcionario);
    foreach(Funcionario i in x.Funcs)
      //if(i is Gerente)
        Console.WriteLine(i);
    Console.WriteLine("Gerentes: ");
    foreach(Gerente i in x.Ger)
        Console.WriteLine(i);
  }
}

class Empresa{
  private List<Funcionario> funcionarios = new List<Funcionario>();
  public void Inserir(Funcionario funcs){
    funcionarios.Add(funcs);
  }
  public List<Funcionario> Funcs{get=>funcionarios;}
  public List<Gerente> Ger{ 
    get{
      List<Gerente> gerentes = new List<Gerente>();
      foreach(Funcionario i in Funcs)
        if(i is Gerente)
          gerentes.Add(i as Gerente);
      return gerentes;
    }
  }
  
}

class Funcionario{
  private string nome;
  protected decimal salarioBase;
  public Funcionario(string n, decimal s){
    this.nome = n;
    this.salarioBase = s;
  }
  public string GetNome(){
    return nome;
  }
  public virtual decimal GetSalario(){
    return salarioBase;
  }
  /*public void SetSalario(deciaml s){
    salarioBase = s; 
  }*/
  public override string ToString(){
    return $"{nome} - {GetSalario()}";
  }
}

class Gerente: Funcionario{
  private decimal gratificacao;
  public Gerente(string n, decimal s, decimal g) : base(n, s){
    this.gratificacao = g;
  }
  public override decimal GetSalario(){
    return /*base.GetSalario()*/ salarioBase + gratificacao;
  }
  public void Premiar(decimal reajuste){
    salarioBase += reajuste;
  }
}