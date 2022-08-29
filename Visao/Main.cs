using System;


public class Program {
  private static bool adminLogado = false;
  private static Usuario leitorLogado = null;
  
  public static void InserirAdmin() {
    Usuario u = new Usuario();
    u.NomeUsuario = "admin";
    u.Senha = "admin";
    u.Admin = true;
    NUsuario.Inserir(u);
  }
  
  public static void Main(){
    InserirAdmin();    
    int op = 0;
    do {
      try {
        op = Menu();
        switch (op) {
            // Categoria
            case 01 : 
              if (Login()) { 
                if (adminLogado) MainAdmin();
                else MainLeitor();
              }
              else 
                Console.WriteLine("Usuário ou senha inválidos");
              break;
            case 02 : Cadastro(); break;
        }
      }
      catch (Exception erro) {
        Console.WriteLine(erro.Message);      
      }
    } while (op != 99);
  }


   public static int Menu() {
    Cor.White();
    Console.WriteLine("———————————————————————————");
    Cor.Magenta();
    Console.WriteLine("• ∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷ •");
    Console.Write("∷∷∷∷∷∷ ");
    Cor.DarkBlue(); 
    Console.Write("BEM-VINDO(A)");
    Cor.Magenta();
    Console.WriteLine(" ∷∷∷∷∷∷∷");
    Console.Write("∷∷∷∷∷∷   ");
    Cor.Green();
    Console.Write("A NOSSA");
    Cor.Magenta();
    Console.Write("    ∷∷∷∷∷∷∷\n");
    Console.Write("∷∷∷∷∷∷  ");
    Cor.Yellow();
    Console.Write("BIBLIOTECA");
    Cor.Magenta();
    Console.WriteLine("  ∷∷∷∷∷∷∷");
    Console.WriteLine("• ∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷ •");
    Cor.White();
    Console.WriteLine("———————————————————————————");
    Cor.DarkRed();
    Console.WriteLine("∷∷∷∷∷∷∷∷ SELECIONE ∷∷∷∷∷∷∷∷");
    Cor.DarkBlue();
    Console.WriteLine("⣿    01 - Login           ⣿");
    Console.WriteLine("⣿    02 - Cadastrar-se    ⣿");
    Cor.DarkRed();
    Console.WriteLine("∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷");
    Cor.DarkBlue();
    Console.WriteLine("⣿    99 - Sair            ⣿");
    Cor.DarkRed();
    Console.WriteLine("∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷");
    Cor.White();
    Console.Write("▶ Opção: ");
    return int.Parse(Console.ReadLine());
   }
  /*-----------------MENU DO LEITOR------------------------*/
  public static void Cadastro(){
    try{
    Console.WriteLine("———————————————————————————");
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷∷∷∷【CADASTRO】∷∷∷∷∷∷∷");
    Cor.White();
    Console.Write("▶ Seu nome: ");
    string nome = Console.ReadLine();
    Console.Write("▶ Nome de usuário: ");
    string nomeusuario = Console.ReadLine();
    Console.Write("▶ Senha: ");
    string senha = Console.ReadLine();

    Usuario u = new Usuario();
    u.NomeUsuario = nomeusuario;
    u.Senha = senha;
    Leitor l = new Leitor();
    l.Nome = nome;
    l.IdUsuario = u.Id;
    NUsuario.Inserir(u);
    NLeitor.Inserir(l);
    
    Cor.Green();
    Console.WriteLine("Usuário Cadastro ✔");
    Cor.White();
    Console.WriteLine("———————————————————————————");
    }
    catch(ArgumentOutOfRangeException){
      Cor.DarkRed();
      Console.WriteLine("Nome de usuário já existe ✘");
      Cor.White();
      Cadastro();
    }
  }
  public static bool Login(){
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷∷∷∷∷【LOGIN】∷∷∷∷∷∷∷∷∷");
    Cor.White();
    Console.Write("▶ Nome de usuário: ");
    string nome = Console.ReadLine();
    Console.Write("▶ Senha: ");
    string senha = Console.ReadLine();
    Usuario u = NUsuario.Autenticar(nome, senha);
    if (u != null) {
      // Alguém logou! true -> admin, false -> cliente
      adminLogado = u.Admin;
      // Cliente logado se estiver no cadastro de clientes
      // o id do usuário informado
      leitorLogado = NUsuario.Pesquisar(u.Id);
      Console.WriteLine("———————————————————————————");
      return true;
    }
    Console.WriteLine("———————————————————————————");
    return false;
  }
  public static void MainLeitor() {
    int op = 0;
    do {
      try {
        op = MenuLeitor();
        switch (op) {
            // Gênero
            case 01 : LeitorGeneroListar(); break;
            case 02 : GeneroBuscar(); break;
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
          case 10: Cadastro(); break;
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
  public static void GeneroBuscar(){
    try{
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷【BUSCAR GÊNERO】∷∷∷∷∷");
    Cor.White();
    Console.Write("▶ Digite Sua Busca 🔎 ou 0\n  para sair: ");
    string busca = Console.ReadLine();
    Genero g = NGenero.Buscar(busca);
    if(g==null){
      Cor.DarkRed();
      Console.WriteLine("Gênero não encontrado ✘");
      Cor.White();
      Console.WriteLine("Deseja fazer uma nova busca: S/N ");
      string resp = Console.ReadLine();
      if(resp.ToUpper() == "N".ToUpper()) MainLeitor();
      GeneroBuscar();
    }
    Cor.Magenta();
    Console.WriteLine(g);
    Cor.White();
    Console.Write("▶ Deseja Listar os Livros\n  do Gênero? S/N ");
    string res = Console.ReadLine();
    if(res.ToUpper() == "N".ToUpper()) MainLeitor();
  
    Cor.White();          
    Console.WriteLine("———————————————————————————");  
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷∷∷∷∷【LIVROS】∷∷∷∷∷∷∷∷");
    Cor.Magenta();
    foreach(Livro i in NLivro.ListarLivroGenero(g))
      Console.WriteLine($"{i.Id} - {i.Titulo} - Autor: {NAutor.Pesquisar(i.IdAutor).Nome}");
    Cor.White();
    Console.Write("▶ Escolher livro ou 0 para\n  voltar: ");
    int idlivro = int.Parse(Console.ReadLine());
    if(idlivro==0){ 
      Cor.White();
      Console.WriteLine("———————————————————————————");
      MainLeitor();
    }
    Livro l = NLivro.Pesquisar(idlivro);
    Leitura nova = new Leitura();
    nova.IdLivro = l.Id;
    nova.IdUsuario = leitorLogado.Id;
    NLeitura.Inserir(nova);
    
    Cor.Green();
    Console.WriteLine("Livro Selecionado ✔"); 
    Cor.White();
    Console.WriteLine("———————————————————————————");
    }
    catch(ArgumentOutOfRangeException){
      Cor.DarkRed();
      Console.WriteLine("Livro Já Selecionado ✘");
      Cor.White();
      Console.WriteLine("———————————————————————————");
      LeitorGeneroListar();
    }
    
    Console.WriteLine("———————————————————————————");
  }
  
  public static void LeitorGeneroListar(){
    try{
    GeneroListar();
    Console.Write("▶ Qual Gênero: ");
    int id = int.Parse(Console.ReadLine());
    Genero g = NGenero.Pesquisar(id);
    Cor.White();          
    Console.WriteLine("———————————————————————————");  
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷∷∷∷∷【LIVROS】∷∷∷∷∷∷∷∷");
    Cor.Magenta();
    foreach(Livro i in NLivro.ListarLivroGenero(g))
      Console.WriteLine($"{i.Id} - {i.Titulo} - Autor: {NAutor.Pesquisar(i.IdAutor).Nome}");
    Cor.White();
    Console.Write("▶ Escolher livro ou 0 para\n  voltar: ");
    int idlivro = int.Parse(Console.ReadLine());
    if(idlivro==0){ 
      Cor.White();
      Console.WriteLine("———————————————————————————");
      MainLeitor();
    }
    else{
      Livro l = NLivro.Pesquisar(idlivro);
      Leitura nova = new Leitura();
      nova.IdLivro = l.Id;
      nova.IdUsuario = leitorLogado.Id;
      NLeitura.Inserir(nova);
    }
    Cor.Green();
    Console.WriteLine("Livro Selecionado ✔"); 
    Cor.White();
    Console.WriteLine("———————————————————————————");
    }
    catch(ArgumentOutOfRangeException){
      Cor.DarkRed();
      Console.WriteLine("Livro Já Selecionado ✘");
      Cor.White();
      Console.WriteLine("———————————————————————————");
      LeitorGeneroListar();
    }
  }
  public static void GeneroInserir(){
    try{
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
    catch(NullReferenceException){
      Cor.DarkRed();
      Console.WriteLine("Gênero já Cadastrado ✘");
      Cor.White();
      Console.WriteLine("———————————————————————————");
      MainAdmin();
    }
  }

  public static void GeneroListar(){
    try{
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
    catch(NullReferenceException){
      Cor.DarkRed();
      Console.WriteLine("Não Há Gêneros ✘");
      Cor.White();
   Console.WriteLine("———————————————————————————");
      MainAdmin();
    }
  }

  public static void GeneroAtualizar(){
    try{
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
    catch(NullReferenceException){
      Cor.DarkRed();
      Console.WriteLine("Não Há Gêneros ✘");
      Cor.White();
      Console.WriteLine("———————————————————————————");
      MainAdmin();
    }
  }
  
  public static void GeneroExcluir(){
    try{
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
    catch(NullReferenceException){
      Cor.DarkRed();
      Console.WriteLine("Não Há Gêneros ✘");
      Cor.White();
      Console.WriteLine("———————————————————————————");
      MainAdmin();
    }
  }

  /*============TRATAMENTO DE LIVRO=====================*/

  public static void LivroInserir(){
    try{
    Console.WriteLine("———————————————————————————");
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷【CADASTRAR LIVRO】∷∷∷∷");
    //DADOS DO NOVO LIVRO A SER INSERIDO
    Cor.White();
    Console.Write("▶ Título: ");
    string titulo = Console.ReadLine();
    //Console.Write("▶ Ano de lançamento: ");
    //int ano = int.Parse(Console.ReadLine());
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
    //novo.SetAnoLancamento(ano);
    novo.IdGenero = genero.Id;
    novo.IdAutor = autor.Id;
    NLivro.Inserir(novo);
    Cor.Green();
    Console.WriteLine("Livro Cadastrado ✔");
    Cor.White();
    Console.WriteLine("———————————————————————————");
      }
    catch(NullReferenceException){
      Cor.DarkRed();
      Console.WriteLine("Livro já Cadastrado ✘");
      Cor.White();
      Console.WriteLine("———————————————————————————");
      MainAdmin();
    }
  }

  public static void LivroListar(){
    Console.WriteLine("———————————————————————————");
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷∷∷∷∷【LIVROS】∷∷∷∷∷∷∷∷");
    Cor.Magenta();
    foreach(Livro i in NLivro.Listar())
      Console.WriteLine($"{i.Id} - {i.Titulo} - Autor: {NAutor.Pesquisar(i.IdAutor).Nome} - Gênero: {NGenero.Pesquisar(i.IdGenero).Descricao}");
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
      Console.WriteLine($"{i.Id} - {i.Titulo} - Autor: {NAutor.Pesquisar(i.IdAutor).Nome} - Gênero: {NGenero.Pesquisar(i.IdGenero).Descricao}");
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
    try{
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
     catch(NullReferenceException){
      Cor.DarkRed();
      Console.WriteLine("Autor já Cadastrado ✘");
      Cor.White();
      Console.WriteLine("———————————————————————————");
      MainAdmin();
    }
  }

  public static void AutorListar(){
    try{
    Console.WriteLine("———————————————————————————");
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷∷∷∷【AUTORES】∷∷∷∷∷∷∷∷");
    Cor.Magenta();
    foreach(Autor i in NAutor.Listar())
      Console.WriteLine(i);
    Cor.White();
    Console.WriteLine("———————————————————————————");
    }
    catch(NullReferenceException){
      Cor.DarkRed();
      Console.WriteLine("Não Há Autore ✘");
      Cor.White();
      Console.WriteLine("———————————————————————————");
      MainAdmin();
    }
  }

  public static void AutorAtualizar(){
    try{
    Console.WriteLine("———————————————————————————");
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷【ATUALIZAR AUTOR】∷∷∷∷");
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
    catch(NullReferenceException){
      Cor.DarkRed();
      Console.WriteLine("Não Há Autores ✘");
      Cor.White();
      Console.WriteLine("———————————————————————————");
      MainAdmin();
    }
  }

  public static void AutorExcluir(){
    try{
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷∷【EXCLUIR AUTOR】∷∷∷∷");
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
    catch(NullReferenceException){
      Cor.DarkRed();
      Console.WriteLine("Não Há Autores ✘");
      Cor.White();
      Console.WriteLine("———————————————————————————");
      MainAdmin();
    }
  }
  /*============TRATAMENTO DE LEITOR ===========*/
  public static void LeitorListar(){
    try{
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷∷∷【LEITORES】∷∷∷∷∷∷∷∷");
    Cor.Magenta();
    foreach(Leitor i in NLeitor.Listar())
      Console.WriteLine($"{i.Id} - {i.Nome}");
    Cor.White();
    Console.WriteLine("———————————————————————————");
    }
    catch(NullReferenceException){
      Cor.DarkRed();
      Console.WriteLine("Não tem Leitores Cadastrados ✘");
      Cor.White();
      Console.WriteLine("———————————————————————————");
      MainAdmin();
    }
    
  }
  public static void LeitorExcluir(){
    try{
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷【EXCLUIR LEITOR】∷∷∷∷");
    Cor.Magenta();
    foreach(Leitor i in NLeitor.Listar())
      Console.WriteLine($"{i.Id} - {i.Nome}");
    Cor.White();
    Console.Write("▶ Id: ");
    int id = int.Parse(Console.ReadLine());
    Leitor x = NLeitor.Pesquisar(id);
    NLeitor.Excluir(x);
    Console.WriteLine("Leitor Excluído ✔");
    Cor.White();
    Console.WriteLine("———————————————————————————");
    }
    catch(NullReferenceException){
      Cor.DarkRed();
      Console.WriteLine("Não tem Leitores Cadastrados ✘");
      Cor.White();
      Console.WriteLine("———————————————————————————");
      MainAdmin();
    }
  }
}