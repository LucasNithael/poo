using System;

class MainClass {
  public static void Main (string[] args) {
    Time time = new Time("XYZ");
    Jogador j1 = new Jogador("ABC", 10);
    Jogador j2 = new Jogador("DEF", 20);
    time.Inserir(j1);
    time.Inserir(j2);
    foreach(Jogador x in time.Listar())
      Console.WriteLine(x);
  }
}

class Jogador {
  private string nome;
  private int camisa;
  public Jogador(string nome, int camisa) {
    this.nome = nome;
    this.camisa = camisa;
  }
  public override string ToString() {
    return $"{nome} {camisa}";
  }
}

class Time {
  private string nome;
  private Jogador[] jogs;
  private int k;
  public Time(string nome) {
    this.nome = nome;
    jogs = new Jogador[6];
  }
  public void Inserir(Jogador jog) {
    if (k < 6) {
      jogs[k] = jog;
      k++;
    }
  }
  public Jogador[] Listar() {
    Jogador[] r = new Jogador[k];
    Array.Copy(jogs, r, k);
    return r;
  }
}

