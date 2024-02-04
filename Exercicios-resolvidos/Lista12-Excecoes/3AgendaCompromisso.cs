using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

class Program{
  public static void Main(){
    CultureInfo ci = new CultureInfo("pt-BR");
    Thread.CurrentThread.CurrentCulture = ci;
    Compromisso a = new Compromisso{Assunto = "Prova de POO", Local = "IFRN", Data = DateTime.Parse("30/06/2022")};
    Compromisso b = new Compromisso{Assunto = "Fazer compras", Local = "Mercadinho do Zé", Data = DateTime.Parse("12/06/2022")};
    Compromisso c = new Compromisso{Assunto = "Comprar um livro", Local = "Centro Cultural", Data = DateTime.Parse("19/12/2022")};
    Agenda x = new Agenda();
    Compromisso d = new Compromisso{Assunto = "Assistir Aula", Local = "IFRN", Data = DateTime.Parse("12/12/2022")};
   
/*A execeção não está funcionando para esse programa*/
    
    x.Inserir(a);  
    x.Inserir(b);
    //x.Excluir(a); 
    //x.Excluir(b); 
    x.Inserir(c);
    x.Inserir(d);
    //x.Inserir(d);
    
    Console.WriteLine("Lista de Compromissos: ");
    foreach(Compromisso i in x.Listar())
      Console.WriteLine(i);

    Console.WriteLine();

    foreach(Compromisso i in x.Pesquisar(6, 2022))
      Console.WriteLine(i);

    Console.WriteLine();
    Console.WriteLine(x.Qtd);
    
  }
}

class Agenda{
  private List<Compromisso> comps = new List<Compromisso>();
  public int Qtd{ get => comps.Count; }
  public void Inserir(Compromisso c){
    foreach(Compromisso i in comps)
      if(i==c)
        throw new InvalidOperationException("Compromisso já existe");
    else comps.Add(c);
  }
  public List<Compromisso> Listar() {
    return comps;
  }
  public void Excluir(Compromisso c) {
    comps.Remove(c);
  }
  public List<Compromisso> Pesquisar(int mes, int ano){
    List<Compromisso> aux = new List<Compromisso>();
    foreach(Compromisso i in comps)
      if(i.Data.Month==mes && i.Data.Year==ano)
        aux.Add(i);
    return aux;
  }
}

class Compromisso{
  public string Assunto {get; set;}
  public string Local {get; set;}
  public DateTime Data {get; set;}
  public override string ToString(){
    return $"Assunto: {Assunto} - Local: {Local} - Data: {Data:dd/MM/yyyy}";
  }
}



