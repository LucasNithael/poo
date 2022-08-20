using System; 

public class Program {

  public static void Main(string[] args) {
    Genero g1 = new Genero{Descricao = "Romanci"};
    Genero g2 = new Genero{Descricao = "Comedia"};
    NGenero gn = new NGenero();
    gn.Inserir(g1);
    gn.Inserir(g2);
    Genero g3 = new Genero{Id = 1, Descricao = "Romance"};
    gn.Atualizar(g3);
    gn.Excluir(g2);
    foreach(Genero i in gn.Listar())
      Console.WriteLine(i);

  }
}