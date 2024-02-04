zusing System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

class Program{
  public static void Main(){
    Pais p1 = new Pais{Nome="França", Ouro=10, Prata=10, Bronze=10};

    QuadroMedalhas m = new QuadroMedalhas();

    
    //m.SalvarCSV("Arquivo.csv");
    m.AbrirCSV("Arquivo.csv");
    foreach(Pais i in m.Listar())
      Console.WriteLine(i);
  }
}

class Pais {
  public string Nome { get;set; }
  public int Ouro { get;set; }
  public int Prata { get;set; }
  public int Bronze { get;set; }
  public override string ToString() {
    return $"{Nome} - {Ouro} - {Prata} - {Bronze}";
  }
}

class QuadroMedalhas{
  List<Pais> paises = new List<Pais>();
  public void Inserir(Pais p){
    paises.Add(p);
  }
  public List<Pais> Listar(){
    return paises;
  }
  public void SalvarCSV(string arquivo){
    StreamWriter f = new StreamWriter(arquivo);
    foreach(Pais i in paises)
      f.WriteLine($"{i.Nome};{i.Ouro};{i.Prata};{i.Bronze}");
    f.Close();
  }
  public void AbrirCSV(string arquivo){
    StreamReader f = new StreamReader(arquivo);
    string s = f.ReadLine();
    while (s != null) {
      string[] v = s.Split(';');
      Pais aux = new Pais{Nome=v[0], Ouro=int.Parse(v[1]), Prata=int.Parse(v[2]), Bronze=int.Parse(v[3])};
      Inserir(aux);
      s = f.ReadLine();
    }
    f.Close();
  }
}