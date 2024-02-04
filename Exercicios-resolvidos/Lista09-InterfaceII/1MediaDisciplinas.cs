using System;

class Program {
  public static void Main() {
    IDisciplina d1 = 
      new DisciplinaSemestral("POO", 100, 100, 0, 160);
    IDisciplina d2 = 
      new DisciplinaSemestral("Arquitetura", 80, 100, 0, 120);
    Historico h = new Historico();
    h.Inserir(d1);
    h.Inserir(d2);
    h.Imprimir();
  }
}

interface IDisciplina {
  string GetNome();
  int CalcMediaParcial();
  int CalcMediaFinal();
}

class Historico {
  private IDisciplina[] disciplinas = new IDisciplina[10];
  private int k;
  public void Imprimir() {
    foreach (IDisciplina d in disciplinas) {
      if (d != null)
        Console.WriteLine($"{d.GetNome()} - {d.CalcMediaFinal()}");
    }
  }
  public void Inserir(IDisciplina d) {
    disciplinas[k++] = d;
  } 
}

class DisciplinaSemestral : IDisciplina {
  private string nome;
  private int nota1, nota2, notaFinal;
  private int ch;
  public DisciplinaSemestral(string nome, int nota1, int nota2, int notaFinal, int ch) {
    this.nome = nome;
    this.nota1 = nota1;
    this.nota2 = nota2;
    this.notaFinal = notaFinal;
    this.ch = ch;
  }
  public string GetNome() { return nome; }
  public int CalcMediaParcial() { return (2*nota1 + 3*nota2)/5; }
  public int CalcMediaFinal() { 
    // implementar a lógica do cálculo
    return (2*nota1 + 3*nota2)/5; 
  }  
  public int CargaHoraria() {
    return ch;
  }
  public override string ToString() {
    return $"{nome} - {notaFinal}";
  }
}

