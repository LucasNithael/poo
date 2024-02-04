using System;

class Program{
  public static void Main(){
    Aplicativo app1 = new Aplicativo{Nome="Facebook", Categoria="Comunicação", Preco=10.00};
    Aplicativo app2 = new Aplicativo{Nome="Netflix", Categoria="Entretenimento", Preco=25.00};
    Aplicativo app3 = new Aplicativo{Nome="Whatsapp", Categoria="Comunicação", Preco=25.00};
    Aplicativo app4 = new Aplicativo{Nome="Notion", Categoria="Educação", Preco=25.00};
    Aplicativo app5 = new Aplicativo{Nome="Call of Duty", Categoria="Game", Preco=25.00};
    Aplicativo app6 = new Aplicativo{Nome="Prime video", Categoria="Entretenimento", Preco=25.00};

    Console.WriteLine();
    Pilha<Aplicativo> l = new Pilha<Aplicativo>();
    l.Push(app1);
    l.Push(app2);
    l.Push(app3);
    l.Push(app4);
    l.Push(app5);

    Console.WriteLine("Lista sem Modicações: ");
    foreach(Aplicativo i in l.Listar())
      Console.WriteLine(i);

    Console.WriteLine("\nUltimo:\n"+l.Peek());

    
    Console.WriteLine("\nRemovidos:\n"+l.Pop());
    Console.WriteLine(l.Pop());
    Console.WriteLine(l.Pop());

    Console.WriteLine("\nNovo ultimo:\n"+l.Peek());


    l.Push(app6);

    Console.WriteLine("\nNovo ultimo:\n"+l.Peek());
    Console.WriteLine("\nNumero de elementos: " + l.Count);
    Console.WriteLine();
    
    Console.WriteLine("Lista com Modicações: ");
    foreach(Aplicativo i in l.Listar())
      Console.WriteLine(i);
    
    l.Clear();
    
    
    Console.WriteLine("\nLista com Modicações: ");
    foreach(Aplicativo i in l.Listar())
      Console.WriteLine(i);

    Console.WriteLine("\nNumero de elementos: " + l.Count);
    Console.WriteLine();
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

class Pilha<T>{
  private T[] objs = new T[1];
  private int k;
  public int Count{get{return k;}}
  public void Clear(){
    this.k=0;
  }
  public T[] Listar(){
    T[] r = new T[k];
    for(int i=0 ; i<k; i++)
      r[i]=objs[i];
    return r;
  }
  public T Peek (){
    T x = objs[k-1];
    return x;
  }
  public void Push (T item){
    if(k==objs.Length)
      Array.Resize(ref objs, 1+objs.Length);
    objs[k++] = item;
  }
  public T Pop (){
    if(k>0) this.k--;
    return objs[k];
  }
}