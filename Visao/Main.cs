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
            case 03 : GeneroAtualizar(); break;
            case 04 : GeneroExcluir(); break;
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
    ConsoleColor foreground = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("━━━━▶  GÊNERO  ◀━━━━");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("▋  01 - Inserir    ▋");
    Console.WriteLine("▋  02 - Listar     ▋");
    Console.WriteLine("▋  03 - Atualizar  ▋");
    Console.WriteLine("▋  04 - Excluir    ▋");
     Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("━━━━▶  LIVRO   ◀━━━━");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("▋  01 - Inserir    ▋");
    Console.WriteLine("▋  02 - Listar     ▋");
    Console.WriteLine("▋  03 - Atualizar  ▋");
    Console.WriteLine("▋  04 - Excluir    ▋");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("━━━━▶  AUTOR   ◀━━━━");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("▋  09 - Listar     ▋");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");
    Console.WriteLine("▋  99 - Logout     ▋");
    Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");
    Console.Write("Opção: ");
    return int.Parse(Console.ReadLine());    
  }
  
  /*==========TRATAMENTO DE GÊNEROS=============*/
  public static void GeneroInserir(){
    ConsoleColor foreground = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("━━▶ NOVO GÊNERO ◀━━━");
    Console.ForegroundColor = ConsoleColor.White;
    //PEDE DADOS DO NOVO GÊNERO
    Console.Write("Descrição: ");
    string desc = Console.ReadLine();
    //INSTANCIA NOVO OBJETO A SER INSERIDO
    Genero novo = new Genero();
    novo.Descricao = desc;
    //CHAMA O MÉTODO INSEIR COM O OBJETO COMO PARÂMETRO
    NGenero.Inserir(novo);
  }

  public static void GeneroListar(){
    ConsoleColor foreground = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("━━━━▶  GÊNEROS  ◀━━━");
    //FAZ A CHAMADA DO MÉTODO LISTA(), ESSE MÉTODO RETORNA UMA LISTA COM OS OBJETOS INSERIDOS ATÉ ENTÃO
    Console.ForegroundColor = ConsoleColor.Magenta;
    foreach(Genero i in NGenero.Listar())
      Console.WriteLine(i);
  }

  public static void GeneroAtualizar(){
    ConsoleColor foreground = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("━▶ ATUALIZAR GÊNERO ◀━");
    //LISTA AS OPÇÕES
    Console.ForegroundColor = ConsoleColor.Magenta;
    foreach(Genero i in NGenero.Listar())
      Console.WriteLine(i);
    //ID DO OBJETO A SER ATUALIZADO E A NOVA DESCRIÇÃO
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Descrição: ");
    string desc = Console.ReadLine();
    //INSTANCIA UM NOVO OBJETO COM ID E DESCRIÇÃO PEDIDOS
    Genero x = new Genero();
    x.Id = id;
    x.Descricao = desc;
    //CHAMA O MÉTODO ATUALIZAR COM A INSTÂNCIA
    NGenero.Atualizar(x);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Gênero Atualizado ✔");
  }
  
  public static void GeneroExcluir(){
    ConsoleColor foreground = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("━━▶ EXCLUIR GÊNERO ◀━");
    //LISTA AS OPÇÕES
    Console.ForegroundColor = ConsoleColor.Magenta;
    foreach(Genero i in NGenero.Listar())
      Console.WriteLine(i);
    //PEDE O ID DO OBJETO A SER EXCLUÍDO
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    //INSTANCIA NOVO OBJETO COM ID INFORMADO
    Genero x = new Genero();
    x.Id = id;
    //CHAMA O MÉTODO EXCLUIR COM A INSTANCIA COMO PARÂMETRO
    NGenero.Excluir(x);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Gênero Excluído ✔"); 
  }
}