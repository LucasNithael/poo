using System;

class MainClass{
  public static void Main(){
    Lote l1 = new Lote{Numero="B5", Vencimento=DateTime.Parse("06/01/2022"), Estoque=10};
    Lote l2 = new Lote{Numero="A32", Vencimento=DateTime.Parse("07/01/2022"), Estoque=15};
    Lote l3 = new Lote{Numero="B4", Vencimento=DateTime.Parse("06/01/2022"), Estoque=5};
    Medicamento m1 = new Medicamento{Nome="paracetamol"};
    
    m1.Inserir(l1);
    m1.Inserir(l2);
    m1.Inserir(l3);
    
    Console.WriteLine($"\n----Informações do Medicamento {m1.Nome}----\n");
    foreach(Lote i in m1.Listar())
      Console.WriteLine($"{m1.Nome} " + i);

    Console.WriteLine($"\n----Total de Estoque do Por data: {m1.Nome}----\n");
      Console.WriteLine(m1.Total(6, 2022));

    Console.WriteLine($"\n----Lista de Lote por mes:  {m1.Nome}----\n");
    foreach(Lote i in m1.Pesquisar(6, 2022))
      Console.WriteLine(i);

    Console.WriteLine($"\n----Quantidade de lote:  {m1.Nome}----\n");
     Console.WriteLine(m1.Qtd);   
        
  }
}

class Lote : IComparable{
  public string Numero{get; set;}
  public DateTime Vencimento{get; set;}
  public int Estoque{get; set;}
  public int CompareTo(object obj){
    Lote x = (Lote)obj;
    if(this.Vencimento.CompareTo(x.Vencimento) == 0)
      return this.Numero.CompareTo(x.Numero);
    else return this.Vencimento.CompareTo(x.Vencimento);
    
  }
  public override string ToString(){
    return $"{Numero} - Vencimento {Vencimento:dd/MM/yyy} - Estoque: {Estoque}";
  }
}

class Medicamento{
  private Lote[] lotes = new Lote[1];
  public string Nome{get; set;}
  private int k;
  public int Qtd{get{return k;}}
  public void Inserir(Lote a){
    if(k==lotes.Length)
      Array.Resize(ref lotes, 1 + lotes.Length);
    lotes[k++] = a;
  } 
  public Lote[] Listar(){
    int l=0;
    foreach(Lote i in lotes)
      if(i!=null)
        l++;
    Lote[] r = new Lote[l];
    int j=0;
    foreach(Lote i in lotes)
      if(i!=null){
        r[j]=i;
        j++;      
      }
    Array.Sort(r);
    return r;
  }
  public Lote[] Pesquisar(int mes, int ano) {
    int l = 0;
    foreach(Lote i in Listar())
      if(i!=null)
        if(i.Vencimento.Month==mes && i.Vencimento.Year==ano)
          l++;
    int m = 0;
    Lote[] r = new Lote[l];
    foreach(Lote i in Listar())
      if(i!=null)
        if(i.Vencimento.Month==mes && i.Vencimento.Year==ano){
          r[m] = i;
          m++;
        }
    return r;
  }
 
    public int Total(int mes, int ano){
      int total = 0;
      foreach(Lote i in Listar())
        if(i.Vencimento.Month==mes && i.Vencimento.Year==ano)
          total = total + i.Estoque;
      return total;
    }
  
}