using System;

class Program{
  public static void Main(){
    Compromisso c1 = new Compromisso{Assunto="Estudar", Local="IFRN", Data=DateTime.Parse("04-04-2023")};
    Compromisso c2 = new Compromisso{Assunto="Malhar", Local="FikFino", Data=DateTime.Parse("05-07-2020")};
    Colecoes<Compromisso> l1 = new Colecoes<Compromisso>();
    l1.Inserir(c1);
    l1.Inserir(c2);
    foreach(Compromisso i in l1.Listar())
      Console.WriteLine(i);

  Console.WriteLine();
    
   Aplicativo app1 = new Aplicativo{Nome="Facebook", Categoria="Comunicação", Preco=10.00};
        Aplicativo app2 = new Aplicativo{Nome="Netflix", Categoria="Entretenimento", Preco=25.00};
      Colecoes<Aplicativo> l2 = new Colecoes<Aplicativo>();
    l2.Inserir(app1);
    l2.Inserir(app2);
    foreach(Aplicativo i in l2.Listar())
      Console.WriteLine(i);
    
  }
}

class Compromisso{
  public string Assunto{get; set;}
  public string Local{get; set;}
  public DateTime Data{get; set;}
  public override string ToString(){
    return $"{Assunto} - {Local} - {Data:dd/MM/yyyy}";
  }
}

class Aplicativo{
  public string Nome{get; set;}
  public string Categoria{get; set;}
  public double Preco{get; set;}
  public override string ToString(){
    return $"{Nome} - {Categoria} - {Preco:c2}";
  }
}

class Colecoes<T> {
  private T[] x = new T[1];
  private int k;
  public void Inserir(T a){
    if(k==x.Length)
      Array.Resize(ref x, 1+x.Length);
    x[k++] = a;
  }
  public T[] Listar(){
    T[] r = new T[k];
    Array.Copy(x, r, k);
    return r;
  }
}