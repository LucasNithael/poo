using System;
using System.Collections.Generic;

class MainClass{
  public static void Main(){
    Construtora constr = new Construtora();
    
    Funcionario a = new Funcionario();
    a.SetNome("Lucas");
    a.SetEmail("Lucas@gmail.com");
    a.SetFone("8491525865");
    
    Motorista b = new Motorista();
    b.SetNome("Nithael");
    b.SetEmail("Nithael@gmail.com");
    b.SetFone("8491525865");
    b.SetCnh("0000777");
    
    Motorista c = new Motorista();
    c.SetNome("Saul");
    c.SetEmail("Saul@gmail.com");
    c.SetFone("8491525865");
    c.SetCnh("00001737");
    
    Engenheiro e = new Engenheiro();
    e.SetNome("Walter");
    e.SetEmail("Walter@gmail.com");
    e.SetFone("8491525865");
    e.SetCrea("123");
    
    Engenheiro f = new Engenheiro();
    f.SetNome("Jesse");
    f.SetEmail("Jesse@gmail.com");
    f.SetFone("8491525865");
    f.SetCrea("3214");
    
    constr.Inserir(a);
    constr.Inserir(b);
    constr.Inserir(c);
    constr.Inserir(e);
    constr.Inserir(f);

    Console.WriteLine("\nFuncionarios: ");
    foreach(Funcionario i in constr.Funcionarios())
      Console.WriteLine(i);

    Console.WriteLine("\nEngenheiros: ");
    foreach(Engenheiro i in constr.Engenheiros())
      Console.WriteLine(i);

    Console.WriteLine("\nMotoristas: ");
    foreach(Motorista i in constr.Motoristas())
      Console.WriteLine(i);
    
    
  }
}

class Construtora{
  private List<Funcionario> funcs = new List<Funcionario>();
  public void Inserir(Funcionario f){
    funcs.Add(f);
  }
  public List<Funcionario> Funcionarios(){
    return funcs;
  }
  public List<Engenheiro> Engenheiros(){
    List<Engenheiro> egs = new List<Engenheiro>();
    foreach(Funcionario i in funcs)
      if(i is Engenheiro)
        egs.Add(i as Engenheiro);
    return egs;
  }
  public List<Motorista> Motoristas(){
    List<Motorista> mots = new List<Motorista>();
    foreach(Funcionario i in funcs)
      if(i is Motorista)
        mots.Add(i as Motorista);
    return mots;
  }
}

class Funcionario: Construtora{
  private string nome;
  private string email;
  private string fone;
  public void SetNome(string n){
    this.nome = n;
  }
  public void SetEmail(string e){
    this.email = e;
  }
  public void SetFone(string f){
    this.fone = f;
  }
  public string GetFone(){
    return fone;
  }
  public string GetNome(){
    return nome;
  }
  public string GetEmail(){
    return email;
  }
  public override string ToString(){
    return $"{nome} - {email} - {fone}";
  }
}

class Engenheiro: Funcionario{
  private string crea;
  public void SetCrea(string c){
    this.crea = c;
  }
  public string GetCrea(){
    return crea;
  }
  public override string ToString(){
    return $"{GetNome()} - {GetEmail()} - {GetFone()} - {crea}";
  }
}

class Motorista: Funcionario{
  private string cnh;
  public void SetCnh(string c){
    this.cnh = c;
  }
  public string GetCnh(){
    return cnh;
  }
  public override string ToString(){
    return $"{GetNome()} - {GetEmail()} {GetFone()} - {cnh}";
  }
}