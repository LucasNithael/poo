using System;
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
     
    
    x.Inserir(a);  
    x.Inserir(b);
    //x.Excluir(a); 
    x.Inserir(c);
    
    Console.WriteLine("Lista de Compromissos: ");
    foreach(Compromisso i in x.Listar())
      Console.WriteLine(i);

    Console.WriteLine();
    Console.WriteLine("=================================================\n");
    
    Console.WriteLine("Lista da Pesquisa: ");
    foreach(Compromisso i in x.Pesquisar(6, 2022))
      Console.WriteLine(i);
    
    
  }
}

class Agenda{
  private Compromisso[] comps = new Compromisso[1]; 
  private int k=0;
  public int Qdt{ get => k; }
  public void Inserir(Compromisso c){
    if(k == comps.Length)
      Array.Resize(ref comps, 1 + comps.Length);
    comps[k] = c;
    k++;
  }
  public Compromisso[] Listar() {
    int l=0;
    foreach(Compromisso i in comps)
      if(i!=null)
        l++;
    int n = 0;
    Compromisso[] h = new Compromisso[l];
    foreach(Compromisso i in comps)
      if(i!=null){
        h[n]=i;
        n++;
      }
        
    return h;
  }
  public Compromisso[] Excluir(Compromisso c) {
    for(int i=0; i<comps.Length; i++)
      if(comps[i]==c)
        comps[i]=null;

    return comps;
  }
  public Compromisso[] Pesquisar(int mes, int ano) {
    int l = 0;
    foreach(Compromisso i in Listar())
      if(i!=null)
        if(i.Data.Month==mes && i.Data.Year==ano)
          l++;
    int m = 0;
    Compromisso[] r = new Compromisso[l];
    foreach(Compromisso i in Listar())
      if(i!=null)
        if(i.Data.Month==mes && i.Data.Year==ano){
          r[m] = i;
          m++;
        }
    return r;
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



