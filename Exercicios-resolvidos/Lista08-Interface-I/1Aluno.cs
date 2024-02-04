using System;
using System.Collections;

class MainClass{
  public static void Main(){
    Aluno a1 = new Aluno{Nome="Lucas", Matricula="20211014040063", Nascimento=DateTime.Parse("04/04/2000")};
        Aluno a2 = new Aluno{Nome="Nithael", Matricula="20211014040055", Nascimento=DateTime.Parse("05/07/1994")};
        Aluno a3 = new Aluno{Nome="Maria", Matricula="20201014040012", Nascimento=DateTime.Parse("01/08/2004")};
    Aluno[] v = {a1, a2, a3};
    Array.Sort(v);
    //AlunoNascComp x = new AlunoNascComp();
    //Array.Sort(v, x);
    //AlunoMatriculaComp y = new AlunoMatriculaComp();
    //Array.Sort(v, y);
    foreach(Aluno i in v){
      Console.WriteLine(i);
    }
  }
}


class Aluno : IComparable{
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
}


class AlunoMatriculaComp : IComparer {
  public int Compare(object x, object y){
    Aluno a = (Aluno)x;
    Aluno b = (Aluno)y;
    return a.Matricula.CompareTo(b.Matricula);
  }
}

class AlunoNascComp : IComparer {
  public int Compare(object x, object y){
    Aluno a = (Aluno)x;
    Aluno b = (Aluno)y;
    return a.Nascimento.CompareTo(b.Nascimento);
  }
}