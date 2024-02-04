using System;
using System.Collections;


class MainClass{  
  public static void Main(){
    Aluno  a1 = new Aluno{Nome="Lucas", Matricula="202110140", Nascimento=DateTime.Parse("04-04-2000")};
    Aluno  a2 = new Aluno{Nome="Aline", Matricula="20216640", Nascimento=DateTime.Parse("05-06-2000")};    
    Aluno  a3 = new Aluno{Nome="Nithael", Matricula="20216640", Nascimento=DateTime.Parse("05-06-2000")};   
    
    Colecao <Aluno> c = new Colecao<Aluno>();
    
    c.Add(a1);
    c.Add(a2);
    c.Add(a3);
    //c.Remove(a2);
    Console.WriteLine("Quantidade de elementos: "+c.Count);

    c.Sort();
    foreach(Aluno i in c.Listar())
      Console.WriteLine(i);
  }
}

class Aluno : IComparable, IEnumerable {
  public string Nome{get; set;}
  public string Matricula{get; set;}
  public DateTime Nascimento{get; set;}
  public int CompareTo(object obj){
    Aluno x = (Aluno)obj;
      return this.Nome.CompareTo(x.Nome);
  }
  public override string ToString(){
    return $"{Nome} |  {Matricula}   | {Nascimento:dd/MM/yyyy}";
  }
  public IEnumerator GetEnumerator() {
    return GetEnumerator();
  }
}

class Colecao <T> where T : IComparable, IEnumerable {
  private T[] objs = new T[10];
  public int Count{get{return k;}}
  public int k=0;
  public T[] Listar(){
    T[] x = new T[k];
    for(int i=0; i<k; i++)
      x[i]=objs[i];
      
    return x;
  }
  public void Add(T obj){
    if(k==objs.Length) Array.Resize(ref objs, 10 * objs.Length);
    objs[k++] = obj;
  }
  public void Remove(T obj){
    int index = -1;
    for(int i=0 ; i<k ; i++)
      if(objs[i].Equals(obj)) 
        index = i;

    for(int i=index ; i<objs.Length-1 ; i++)
      objs[i]=objs[i+1];
    k--;
  }
  public void Sort(){
    Array.Sort(objs); //Está colando os elementos Null para primeiro na ordenação
  }
   public IEnumerator GetEnumerator() {
    T[] aux = new T[k];
    Array.Copy(objs, aux, k);
    return aux.GetEnumerator();     
  }
}



