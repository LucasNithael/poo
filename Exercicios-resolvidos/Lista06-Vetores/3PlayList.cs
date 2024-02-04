using System;

class Program {
  public static void Main() {
    Musica m1 = new Musica("Imagine");
    Musica m2 = new Musica("Yellow Submarine");
    Musica m3 = new Musica("The Long and Winding Road");
    Musica m4 = new Musica("Hotel California");
    //Console.WriteLine(m1);
    //Console.WriteLine(m2);
    PlayList lista = new PlayList("Rock");
    lista.Inserir(m1);
    lista.Inserir(m2);
    lista.Inserir(m3);
    lista.Inserir(m4);
    Console.WriteLine(lista);
    foreach(Musica m in lista.Listar())
      Console.WriteLine(m);
  }
}

class PlayList {
  private string nome;
  private Musica[] musicas = new Musica[1];
  private int k = 0;
  public PlayList(string nome) {
    this.nome = nome;
  }
  public void Inserir(Musica m) {
    if (k == musicas.Length)
      Array.Resize(ref musicas, 2 * musicas.Length); 
    musicas[k++] = m;
  }
  public Musica[] Listar() {
    Musica[] r = new Musica[k];
    Array.Copy(musicas, r, k);
    return r;
  }
  public override string ToString() {
    return $"PlayList {nome} tem {k} música(s)";
  }
}

class Musica {
  private string titulo;
  public Musica(string titulo) {
    this.titulo = titulo;
  }
  public override string ToString() {
    return $"{titulo}";
  }
}