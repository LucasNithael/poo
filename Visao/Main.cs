using System;


public class Program {

  public static void Main(){
  
    MainAdmin();
   // MainLeitor();
  }
  /*-----------------MENU DO LEITOR------------------------*/
  public static void MainLeitor() {
    int op = 0;
    do {
      try {
        op = MenuLeitor();
        switch (op) {
            // Gênero
            case 01 : GeneroListar(); break;
            //case 02 : GeneroBuscar(); break;
            //Autor
            //case 03 : AutorListar(); break;
            //case 04 : AutorBuscar(); break;
            //Livro
            //case 05 : LivroEscolher(); break;
            //case 06 : LivroListar(); break;
            //case 07 : LivroBuscar(); break;
            //Leitura
            //case 08 : LeituraListar(); break;
            //case 09 : LeituraFechar(); break;

          }
      }
      catch (Exception erro) {
        Console.WriteLine(erro.GetType() + "\n" + erro.Message);      
      }
    } while (op != 00);
  }

   public static int MenuLeitor() {
    Cor.Magenta();
    Console.WriteLine("∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷");
    Console.Write("∷∷∷∷∷∷ ");
    Cor.Green();
    Console.Write("O QUE DESEJA?");
    Cor.Magenta();
    Console.Write(" ∷∷∷∷∷∷\n");
    Console.WriteLine("∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷");
    Cor.DarkRed();
    Console.WriteLine("∷∷∷∷∷∷∷∷∷【GÊNERO】∷∷∷∷∷∷∷∷");
    Cor.DarkBlue();
    Console.WriteLine("⣿  01 - Listar Gêneros    ⣿");
    Console.WriteLine("⣿  02 - Buscar Gênero     ⣿");
    Cor.DarkRed(); 
    Console.WriteLine("∷∷∷∷∷∷∷∷∷【AUTOR】∷∷∷∷∷∷∷∷∷");
    Cor.DarkBlue(); 
    Console.WriteLine("⣿  03 - Listar Autores    ⣿");
    Console.WriteLine("⣿  04 - Buscar Autor      ⣿");
    Cor.DarkRed();
    Console.WriteLine("∷∷∷∷∷∷∷∷∷【LIVRO】∷∷∷∷∷∷∷∷∷"); 
    Cor.DarkBlue();
    Console.WriteLine("⣿  05 - Escolher Livro    ⣿");
    Console.WriteLine("⣿  06 - Listar Livros     ⣿");
    Console.WriteLine("⣿  07 - Buscar Livro      ⣿");
    Cor.DarkRed(); 
    Console.WriteLine("∷∷∷∷∷∷∷∷【LEITURA】∷∷∷∷∷∷∷∷"); 
    Cor.DarkBlue();
    Console.WriteLine("⣿  08 - Listar Leitura    ⣿");
    Console.WriteLine("⣿  09 - Fechar Leitura    ⣿");
    Console.WriteLine("∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷");
    Console.WriteLine("⣿  00 - Logout            ⣿");
    Console.WriteLine("∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷");
    Cor.White();
    Console.Write("▶ Opção: ");
    return int.Parse(Console.ReadLine());    
  }
  /*------------------MENU DO ADMIN------------------------*/
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
            case 05 : LivroInserir(); break;
            case 06 : LivroListar(); break;
            case 07 : LivroAtualizar(); break;
            case 08 : LivroExcluir(); break;
            // Autor
            case 09 : AutorInserir(); break;
            case 10 : AutorListar(); break;
            case 11 : AutorAtualizar(); break;
            case 12 : AutorExcluir(); break;
            // Leitor
            case 13 : LeitorListar(); break;
            case 14 : LeitorExcluir(); break;
          }
      }
      catch (Exception erro) {
        Console.WriteLine(erro.GetType() + "\n" + erro.Message);      
      }
    } while (op != 00);
  }

   public static int MenuAdmin() {
    Cor.Magenta();
    Console.WriteLine("∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷");
    Console.Write("∷∷∷∷∷∷ ");
    Cor.Green();
    Console.Write("O QUE DESEJA?");
    Cor.Magenta();
    Console.Write(" ∷∷∷∷∷∷\n");
    Console.WriteLine("∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷");
    Cor.DarkRed();
    Console.WriteLine("∷∷∷∷∷∷∷∷∷【GÊNERO】∷∷∷∷∷∷∷∷");
    Cor.DarkBlue();
    Console.WriteLine("⣿  01 - Inserir           ⣿");
    Console.WriteLine("⣿  02 - Listar Gêneros    ⣿");
    Console.WriteLine("⣿  03 - Atualizar         ⣿");
    Console.WriteLine("⣿  04 - Excluir           ⣿");
    Cor.DarkRed();
    Console.WriteLine("∷∷∷∷∷∷∷∷∷【LIVRO】∷∷∷∷∷∷∷∷∷");
    Cor.DarkBlue();
    Console.WriteLine("⣿  05 - Inserir           ⣿");
    Console.WriteLine("⣿  06 - Listar            ⣿");
    Console.WriteLine("⣿  07 - Atualizar         ⣿");
    Console.WriteLine("⣿  08 - Excluir           ⣿");
    Cor.DarkRed();
    Console.WriteLine("∷∷∷∷∷∷∷∷∷【AUTOR】∷∷∷∷∷∷∷∷∷");
    Cor.DarkBlue();
    Console.WriteLine("⣿  09 - Inserir           ⣿");
    Console.WriteLine("⣿  10 - Listar            ⣿");
    Console.WriteLine("⣿  11 - Atualizar         ⣿");
    Console.WriteLine("⣿  12 - Excluir           ⣿");
    Cor.DarkRed();
    Console.WriteLine("∷∷∷∷∷∷∷∷∷【LEITOR】∷∷∷∷∷∷∷∷");
    Cor.DarkBlue();
    Console.WriteLine("⣿  13 - Listar            ⣿");
    Console.WriteLine("⣿  14 - Excluir           ⣿");
    Console.WriteLine("∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷");
    Console.WriteLine("⣿  00 - Logout            ⣿");
    Console.WriteLine("∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷");
    Cor.White();
    Console.Write("▶ Opção: ");
    return int.Parse(Console.ReadLine());    
  }
  
  /*==========TRATAMENTO DE GÊNEROS=============*/
  public static void GeneroInserir(){
    Console.WriteLine("———————————————————————————");
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷∷【NOVO GÊNERO】∷∷∷∷∷∷");
    Cor.White();
    Cor.White();
    //PEDE DADOS DO NOVO GÊNERO
    Console.Write("▶ Descrição: ");
    string desc = Console.ReadLine();
    //INSTANCIA NOVO OBJETO A SER INSERIDO
    Genero novo = new Genero();
    novo.Descricao = desc;
    //CHAMA O MÉTODO INSEIR COM O OBJETO COMO PARÂMETRO
    NGenero.Inserir(novo);
    Cor.Green();
    Console.WriteLine("Gênero Cadastrado ✔");
    Cor.White();
    Console.WriteLine("———————————————————————————");
  }

  public static void GeneroListar(){
    Console.WriteLine("———————————————————————————");
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷∷∷∷【GÊNEROS】∷∷∷∷∷∷∷∷");
    //FAZ A CHAMADA DO MÉTODO LISTA(), ESSE MÉTODO RETORNA UMA LISTA COM OS OBJETOS INSERIDOS ATÉ ENTÃO
    Cor.Magenta();
    foreach(Genero i in NGenero.Listar())
      Console.WriteLine(i);
    Cor.White();
    Console.WriteLine("———————————————————————————");
  }

  public static void GeneroAtualizar(){
    Console.WriteLine("———————————————————————————");
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷【ATUALIZAR GÊNERO】∷∷∷");
    //LISTA AS OPÇÕES
    Cor.Magenta();
    foreach(Genero i in NGenero.Listar())
      Console.WriteLine(i);
    //ID DO OBJETO A SER ATUALIZADO E A NOVA DESCRIÇÃO
    Cor.White();
    Console.Write("▶ Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("▶ Descrição: ");
    string desc = Console.ReadLine();
    //INSTANCIA UM NOVO OBJETO COM ID E DESCRIÇÃO PEDIDOS
    Genero x = new Genero();
    x.Id = id;
    x.Descricao = desc;
    //CHAMA O MÉTODO ATUALIZAR COM A INSTÂNCIA
    NGenero.Atualizar(x);
    Cor.Green();
    Console.WriteLine("Gênero Atualizado ✔");
    Cor.White();
    Console.WriteLine("———————————————————————————");
  }
  
  public static void GeneroExcluir(){
    Console.WriteLine("———————————————————————————");
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷【EXCLUIR GÊNERO】∷∷∷∷");
    //LISTA AS OPÇÕES
    Cor.Magenta();
    foreach(Genero i in NGenero.Listar())
      Console.WriteLine(i);
    //PEDE O ID DO OBJETO A SER EXCLUÍDO
    Cor.White();
    Console.Write("▶ Id: ");
    int id = int.Parse(Console.ReadLine());
    //INSTANCIA NOVO OBJETO COM ID INFORMADO
    Genero x = new Genero();
    x.Id = id;
    //CHAMA O MÉTODO EXCLUIR COM A INSTANCIA COMO PARÂMETRO
    NGenero.Excluir(x);
    Cor.Green();
    Console.WriteLine("Gênero Excluído ✔"); 
    Cor.White();
    Console.WriteLine("———————————————————————————");
  }

  /*============TRATAMENTO DE LIVRO=====================*/

  public static void LivroInserir(){
    Console.WriteLine("———————————————————————————");
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷【CADASTRAR LIVRO】∷∷∷∷");
    //DADOS DO NOVO LIVRO A SER INSERIDO
    Cor.White();
    Console.Write("▶ Título: ");
    string titulo = Console.ReadLine();
    Console.Write("▶ Ano de lançamento: ");
    int ano = int.Parse(Console.ReadLine());
    //OPÇÕES DE GÊNERO QUE O LIVRO PERTENCE
    Cor.Magenta();
    foreach(Genero i in NGenero.Listar())
      Console.WriteLine(i);
    Cor.White();
    Console.Write("▶ Id do Gênero: ");
    int idgenero = int.Parse(Console.ReadLine());
    //OPÇÕES DE AUTORES
    Cor.Magenta();
    foreach(Autor i in NAutor.Listar())
      Console.WriteLine(i);
    Cor.White();
    Console.Write("▶ Id do Autor: ");
    int idautor = int.Parse(Console.ReadLine());
    
    //INSTÂNCIA DO NOVO OBJETO LIVRO, GENERO E AUTOR. GENERO E AUTOR SERVEM PARA RECUPERAR OS ID PARA INSERIR NO LIVRO
    Genero genero = NGenero.Pesquisar(idgenero);
    Autor autor = NAutor.Pesquisar(idautor);
    Livro novo = new Livro();
    novo.Titulo = titulo;
    novo.SetAnoLancamento(ano);
    novo.IdGenero = genero.Id;
    novo.IdAutor = autor.Id;
    NLivro.Inserir(novo);
    Cor.Green();
    Console.WriteLine("Livro Cadastrado ✔");
    Cor.White();
    Console.WriteLine("———————————————————————————");
  }

  public static void LivroListar(){
    Console.WriteLine("———————————————————————————");
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷∷∷∷∷【LIVROS】∷∷∷∷∷∷∷∷");
    Cor.Magenta();
    foreach(Livro i in NLivro.Listar())
      Console.WriteLine(i);
    Cor.White();
    Console.WriteLine("———————————————————————————");
  }
  public static void LivroAtualizar(){
    Console.WriteLine("———————————————————————————");
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷【ATUALIZAR LIVRO】∷∷∷∷");
    //OPÇÕES DE LIVROS PARA ATUALIZAR
    Cor.Magenta();
    foreach(Livro i in NLivro.Listar())
      Console.WriteLine(i);
    //ID E DADOS A SEREM ATUALIZADOS
    Cor.White();
    Console.Write("▶ Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("▶ Título: ");
    string titulo = Console.ReadLine();
    Console.Write("▶ Ano: ");
    int ano = int.Parse(Console.ReadLine());
    //NOVA INSTÂNCIA COM OBJETOS COM DADOS PARA ATUALIZAÇÃO
    Livro x = NLivro.Pesquisar(id);
    x.Titulo = titulo;
    x.SetAnoLancamento(ano);
    //CHAMADA DE MÉTODO PARA ATULIZAÇÃO
    NLivro.Atualizar(x);
    Cor.Green();
    Console.WriteLine("Livro Atualizado ✔");
    Cor.White();
    Console.WriteLine("———————————————————————————");
  }
  public static void LivroExcluir(){
    Console.WriteLine("———————————————————————————");
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷【EXCLUIR LIVRO】∷∷∷∷∷");
    //LISTA AS OPÇÕES
    Cor.Magenta();
    foreach(Livro i in NLivro.Listar())
      Console.WriteLine(i);
    //PEDE O ID DO OBJETO A SER EXCLUÍDO
    Cor.White();
    Console.Write("▶ Id: ");
    int id = int.Parse(Console.ReadLine());
    //INSTANCIA NOVO OBJETO COM ID INFORMADO
    Livro x = new Livro();
    x.Id = id;
    //CHAMA O MÉTODO EXCLUIR COM A INSTANCIA COMO PARÂMETRO
    NLivro.Excluir(x);
    Cor.Green();
    Console.WriteLine("Livro Excluído ✔");
    Cor.White();
    Console.WriteLine("———————————————————————————");
  }

  /*===============TRATAMENTO DE AUTOR================*/
  public static void AutorInserir(){
    Console.WriteLine("———————————————————————————");
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷【CADASTRAR AUTOR】∷∷∷∷");
    Cor.White();
    //PEDE DADOS DO NOVO AUTOR
    Console.Write("▶ Nome: ");
    string nome = Console.ReadLine();
    //INSTANCIA NOVO OBJETO A SER INSERIDO
    Autor novo = new Autor();
    novo.Nome = nome;
    //CHAMA O MÉTODO INSEIR COM O OBJETO COMO PARÂMETRO
    NAutor.Inserir(novo);
    Cor.Green();
    Console.WriteLine("Autor Cadastrado ✔");
    Cor.White();
    Console.WriteLine("———————————————————————————");
  }

  public static void AutorListar(){
    Console.WriteLine("———————————————————————————");
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷∷∷∷【AUTORES】∷∷∷∷∷∷∷∷");
    Cor.Magenta();
    foreach(Autor i in NAutor.Listar())
      Console.WriteLine(i);
    Cor.White();
    Console.WriteLine("———————————————————————————");
  }

  public static void AutorAtualizar(){
    Cor.Yellow();
    Console.WriteLine("━━━━▶ ATUALIZAR AUTOR ◀━━━━");
    Cor.Magenta();
    foreach(Autor i in NAutor.Listar())
      Console.WriteLine(i);
    Cor.White();
    Console.Write("▶ Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("▶ Novo nome: ");
    string nome = Console.ReadLine();
    Autor x = NAutor.Pesquisar(id);
    x.Nome = nome;
    NAutor.Atualizar(x);
    Cor.Green();
    Console.WriteLine("Autor Atualizado ✔");
    Cor.White();
    Console.WriteLine("———————————————————————————");
  }

  public static void AutorExcluir(){
    Cor.Yellow();
    Console.WriteLine("━━━━▶ EXCLUIR AUTOR ◀━━━━");
    Cor.Magenta();
    foreach(Autor i in NAutor.Listar())
      Console.WriteLine(i);
    Cor.White();
    Console.Write("▶ Id: ");
    int id = int.Parse(Console.ReadLine());
    Autor x = NAutor.Pesquisar(id);
    NAutor.Excluir(x);
    Cor.Green();
    Console.WriteLine("Autor Excluído ✔");
    Cor.White();
    Console.WriteLine("———————————————————————————");
  }
  /*============TRATAMENTO DE LEITOR ===========*/
  public static void LeitorListar(){
    Cor.Yellow();
    Console.WriteLine("━━━━▶  LEITORES  ◀━━━━");
    Cor.Magenta();
    foreach(Livro i in NLivro.Listar())
      Console.WriteLine(i);
    Cor.White();
    Console.WriteLine("———————————————————————————");
  }
  public static void LeitorExcluir(){
    Cor.Yellow();
    Console.WriteLine("━━━━▶ EXCLUIR LEITOR ◀━━━━");
    Cor.Magenta();
    foreach(Leitor i in NLeitor.Listar())
      Console.WriteLine(i);
    Cor.White();
    Console.Write("▶ Id: ");
    int id = int.Parse(Console.ReadLine());
    Leitor x = NLeitor.Pesquisar(id);
    NLeitor.Excluir(x);
    Console.WriteLine("Leitor Excluído ✔");
    Cor.White();
    Console.WriteLine("———————————————————————————");
  }
}