using System; 

public class Program {

  public static void Main(){
  
    MainAdmin();
  }
  public static void MainAdmin() {
    int op = 0;
    do {
      try {
        op = MenuAdmin();
        switch (op) {
            // Gênero
            case 01 : GeneroInserir(); break;
            case 02 : GeneroListar(); break;
            //case 03 : GeneroAtualizar(); break;
            //case 04 : GeneroExcluir(); break;
            // Livro
            //case 05 : LivroInserir(); break;
            //case 06 : LivroListar(); break;
            //case 07 : LivroAtualizar(); break;
            //case 08 : LivroExcluir(); break;
            // Autor
            //case 09 : AutorInserir(); break;
            //case 10 : AutorListar(); break;
            //case 11 : AutorAtualizar(); break;
            //case 12 : AutorExcluir(); break;
          }
      }
      catch (Exception erro) {
        Console.WriteLine(erro.GetType() + "\n" + erro.Message);      
      }
    } while (op != 99);
  }

   public static int MenuAdmin() {
    Console.WriteLine();
    Console.WriteLine("---- GÊNERO -----");
    Console.WriteLine("  01 - Inserir");
    Console.WriteLine("  02 - Listar");
    Console.WriteLine("  03 - Atualizar");
    Console.WriteLine("  04 - Excluir");
    Console.WriteLine("------ Produtos ------");
    Console.WriteLine("  05 - Inserir");
    Console.WriteLine("  06 - Listar");
    Console.WriteLine("  07 - Atualizar");
    Console.WriteLine("  08 - Excluir");
    Console.WriteLine("------ Vendas ------");
    Console.WriteLine("  09 - Listar");
    Console.WriteLine("----------------------");
    Console.WriteLine("  99 - Logout");
    Console.WriteLine("----------------------");
    Console.Write("Opção: ");
    return int.Parse(Console.ReadLine());    
  }
  
  /*==========TRATAMENTO DE GÊNEROS=============*/
  public static void GeneroInserir(){
    Genero novo = new Genero();
    
    
    Console.WriteLine("\n-----| NOVO GÊNERO |-----");
    Console.Write("Descrição: ");
    string desc = Console.ReadLine();
    novo.Descricao = desc;
    NGenero.Inserir(novo);
  }

  public static void GeneroListar(){
    Console.WriteLine("\n-----| GÊNEROS |-----");
    foreach(Genero i in NGenero.Listar())
      Console.WriteLine(i);
  }
  
}