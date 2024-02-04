using System;

class MainClass{
  public static void Main(){
    Pais p1 = new Pais("França", 10, 10, 1);
    Pais p2 = new Pais("Brasil", 10, 10, 1);
    Pais p3 = new Pais("EUA", 10, 1, 1);
    Pais p4 = new Pais("Japão", 2, 15, 1);

    QuadroMedalhas m = new QuadroMedalhas();

    m.Inserir(p1);
    m.Inserir(p2);
    m.Inserir(p3);
    m.Inserir(p4);
    
    Array.Sort(m.Listar());
    Array.Reverse(m.Listar());
    
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
          if(this.nome.CompareTo(x.nome)==1)
            return -1;
          else return 1;
        }
        else return this.bronze.CompareTo(x.bronze);
      }
      else return this.prata.CompareTo(x.prata);
    }
    else return this.ouro.CompareTo(x.ouro);
  }

  public override string ToString(){
    return $"{nome}\nOuro: {ouro}\nPrata: {prata}\nBronze: {bronze}\n";
  }
}
class QuadroMedalhas{
  private Pais[] paises = new Pais[1];
  private int k;
  public void Inserir(Pais p){
    if(k==paises.Length)
      Array.Resize(ref paises, 1 + paises.Length);
    paises[k] = p;
    k++;
  }
  public Pais[] Listar(){
    return paises;
  }
}