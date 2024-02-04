using System;

enum Dias{seg, ter, qua, qui, sex};
enum Turno{matutino, vespertino, noturno};

class Program{
  public static void Main(){
    Estagiario e = new Estagiario("Lucas", "705.415.194-17", "(84) 99152-5865");
    e.SetDias(Dias.seg);
    e.SetTurno(Turno.matutino);
    Console.WriteLine(e);
  }
}

class Estagiario{
  private string nome;
  private string cpf;
  private string telefone;
  private Dias dias = Dias.seg;
  private Turno turno;
  public Estagiario(string n, string c, string t){
    nome = n; cpf = c; telefone = t;
  }
  public void SetDias(Dias d){
    dias = d;
  }
  public void SetTurno(Turno tu){
    turno = tu;
  }
  public Dias GetDias(){
    return dias;
  }
  public Turno GetTurno(){
    return turno;
  }
  public override string ToString(){
    return $"{nome}, {cpf}, {telefone}\nDia: {dias} - Turno: {turno}";
  }
}