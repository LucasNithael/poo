using System;
using System.Collections;

class MainClass{
  public static void Main(){
    Aluno a = new Aluno("Lucas", DateTime.Parse("04/04/2000"));
    Aluno b = new Aluno("Maria", DateTime.Parse("01/01/1993"));
    Aluno c = new Aluno("Paulo", DateTime.Parse("01/01/1991"));
    Aluno[] v = {a, b, c};
    //Array.Sort(v);
    AlunoNascComp x = new AlunoNascComp();
    Array.Sort(v, x);
    foreach(Aluno i in v) Console.WriteLine(i);

    Console.WriteLine("\nAlunos Aniversariantes:");
    Relatorio.Aniversariantes(v, 1);

    Professor p1 = new Professor{Nome="Gilbert", Nascimento=DateTime.Parse("01/03/1980")};
    Professor p2 = new Professor{Nome="Jorgiano", Nascimento=DateTime.Parse("07/12/1969")};
    Professor[] w = {p1, p2};

    Console.WriteLine("\nProfessores Aniversariantes:");
    Relatorio.Aniversariantes(w, 1);

    IPessoa[] vw = {a, b, c, p1, p2};
    Console.WriteLine("\nProfessores e Alunos Aniversariantes:");
    Relatorio.Aniversariantes(vw, 1);  


    Turma t = new Turma();
    t.SetProfessor(p1);
    t.InserirAlunos(a);
    t.InserirAlunos(b);
    //t.InserirAlunos(c);
    Console.WriteLine("\n" + t);
    foreach(Aluno i in t.ListarAlunos())
      Console.WriteLine(i);
  }
}

class Turma : IEnumerable{
  private Professor prof;
  private Aluno[] alunos = new Aluno[1];
  private int k;
  public void SetProfessor(Professor p){
    this.prof = p;
  }
  public void InserirAlunos(Aluno a){
    if(k==alunos.Length)
      Array.Resize(ref alunos, 1+alunos.Length);
    alunos[k] = a;
    k++;
  }
  public Aluno[] ListarAlunos(){
    return alunos;
  }
  public IEnumerator GetEnumerator(){
    return alunos.GetEnumerator();
  }
  public override string ToString(){
    return $"{prof.Nome} - {k} alunos"; 
  }
}

interface IPessoa{
  string Nome {get; set;}
  DateTime Nascimento{get; set;}
}

class Professor : IPessoa{
  public string Nome {get; set;}
  public DateTime Nascimento {get; set;}
}

class Relatorio{
  public static void Aniversariantes(IPessoa[] v, int mes){
    foreach(IPessoa p in v)
      if(p.Nascimento.Month == mes)
        Console.WriteLine(p.Nome);
  }
}

class Aluno : IComparable, IPessoa{
  private string nome;
  private DateTime nasc;
  public string Nome {get => nome; set => nome = value;}
  public DateTime Nascimento {get => nasc; set => nasc = value;}
  public Aluno(string n, DateTime d){
    this.nome = n;
    this.nasc = d;
  }
  public int CompareTo(object obj){
    Aluno x = (Aluno)obj;
    return this.nome.CompareTo(x.nome);
  }
  
  public override string ToString(){
    return $"{nome} {nasc:dd/MM/yyyy}";
  }
}

class AlunoNascComp : IComparer{
  public int Compare(object x, object y){
    Aluno a = (Aluno)x;
    Aluno b = (Aluno)y;
    return a.Nascimento.CompareTo(b.Nascimento);
  }
}