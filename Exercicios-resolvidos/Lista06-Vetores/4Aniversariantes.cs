using System;
using System.Globalization;
using System.Threading;

class MainClass{
  public static void Main(){
    CultureInfo ci = new CultureInfo("pt-BR");
    Thread.CurrentThread.CurrentCulture = ci;
    Contato cont1 = new Contato("Lucas", "8491525865", DateTime.Parse("04/04/2000"));
    Contato cont2 = new Contato("Nithael", "40028922", DateTime.Parse("07/05/2000"));
    Contato cont3 = new Contato("Silva", "40028922", DateTime.Parse("08/05/2000"));
    Contato cont4 = new Contato("Souza", "40028922", DateTime.Parse("09/05/2000"));
    Contato cont5 = new Contato("Bom e Cia", "40028922", DateTime.Parse("25/05/2000"));
    Agenda a = new Agenda();
    a.Inserir(cont1);
    a.Inserir(cont2);
    a.Inserir(cont3);
    a.Inserir(cont4);
    a.Inserir(cont5);
    //foreach(Contato i in a.Listar())
      //Console.WriteLine(i);
    
    foreach(Contato i in a.AniversarianteMes(5))
      Console.WriteLine(i);
  }
}

class Contato{
  private string nome;
  private string telefone;
  private DateTime nascimento;
  public Contato(string n, string t, DateTime nasc){
    this.nome=n; 
    this.telefone=t; 
    this.nascimento=nasc;
  }
  public override string ToString(){
    return $"{nome} {telefone} {nascimento:dd/MM}";
  }
  public int GetMes(){
    return nascimento.Month;
  }
}


class Agenda{
  private Contato[] contato = new Contato[1];
  private int k = 0;
  
  public void Inserir(Contato x){
      if (k == contato.Length)
        Array.Resize(ref contato, 1 + contato.Length); 
      contato[k] = x;
      k++;
  }
  public Contato[] Listar(){
    return contato;  
  }
  public Contato[] AniversarianteMes(int mes){
    int j = 0;
    foreach(Contato i in Listar())
      if(i.GetMes()==mes){
        j++;  
      }
      
    Contato[] r = new Contato[j];
    int l = 0;
    foreach(Contato i in Listar())
       if(i.GetMes()==mes){
          r[l] = i;
            l++;
      }
    return r;
  }
}