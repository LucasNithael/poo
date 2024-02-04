using System;
using System.Collections.Generic;

class MainClass{
  public static void Main(){
    Pais p1 = new Pais("França", 10, 10, 10);
    Pais p2 = new Pais("Brasil", 10, 10, 10);
    Pais p3 = new Pais("EUA", 10, 10, 10);
    Pais p4 = new Pais("Japão", 10, 10, 10);

    QuadroMedalhas m = new QuadroMedalhas();

    m.Inserir(p1);
    m.Inserir(p2);
    m.Inserir(p3);
    m.Inserir(p4);
    
    
    foreach(Pais x in m.Listar())
      Console.WriteLine(x);
  }
}

class Pais : IComparable{
  private string nome;
  private int ouro;
  private int prata;
  private int bronze;
  public Pais(string n, int o, int p, int b){
    nome=n; ouro=o; prata=p; bronze=b;
  }
  public int CompareTo(object obj){
    Pais x = (Pais)obj;
    if((this.ouro.CompareTo(x.ouro))==0){
      if((this.prata.CompareTo(x.prata))==0){
        if((this.bronze.CompareTo(x.bronze))==0){
          return this.nome.CompareTo(x.nome);}
        else return -this.bronze.CompareTo(x.bronze);}
      else return -this.prata.CompareTo(x.prata);}
    else return -this.ouro.CompareTo(x.ouro);
  }

  public override string ToString(){
    return $"{nome}\nOuro: {ouro}\nPrata: {prata}\nBronze: {bronze}\n";
  }
}
class QuadroMedalhas{
  SortedList<string, int> d = new SortedList<string, int>();
  public void Inserir(Pais p){
    paises.Add(p);
  }
  public List<Pais> Listar(){
    paises.Sort();
    return paises;
  }
}