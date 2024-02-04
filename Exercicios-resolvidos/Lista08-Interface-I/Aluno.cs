using System;
using System.Collections;

class MainClass{
  public static void Main(){
    Aluno a1 = new Aluno("Lucas", DateTime.Parse("04/07/2000"));
    Aluno a2 = new Aluno("Nithael", DateTime.Parse("05/06/2000"));
    Aluno a3 = new Aluno("Thiago", DateTime.Parse("11/05/1990"));
    Aluno[] v = {a1, a2, a3};
    Array.Sort(v);
    
    AlunoNascComp x = new AlunoNascComp();
    Array.Sort(v, x);
    foreach(Aluno i in v){
      Console.WriteLine(i);
    }
    
    
    
  }
}


class Aluno : IComparable {
  private string nome;
  private DateTime nasc;
  public Aluno(string nome, DateTime nasc){
    this.nome = nome;
    this.nasc = nasc;
  }
  public override string ToString(){
    return $"{nome} {nasc:dd/MM/yyyy}";
  }
  public int CompareTo(object obj){
    Aluno x = (Aluno)obj;
    return this.nome.CompareTo(x.nome);
  }
  public DateTime GetNasc(){
    return nasc;
  }
}

class AlunoNascComp : IComparer {
  public int Compare(object x, object y){
    Aluno a = (Aluno)x;
    Aluno b = (Aluno)y;
    return a.GetNasc().CompareTo(b.GetNasc());
  }
}