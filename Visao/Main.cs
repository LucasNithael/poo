using System;

public class Program {
  private static bool adminLogado = false;
  private static Usuario leitorLogado = null;
  
  public static void InserirAdmin() {
    Usuario u = new Usuario();
    u.Nome = "Administrador";
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
                Cor.DarkRed();
                Console.WriteLine("Usuário ou Senha Inválidos ✘");
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
      leitorLogado = u;
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
            case 01 : UsuarioGeneroListar(); break;
            case 02 : GeneroBuscar(); break;
            //Autor
            case 03 : UsaurioAutorListar(); break;
            case 04 : AutorBuscar(); break;
            //Livro
            case 05 : UsuarioLivroListar(); break;
            case 06 : UsuarioLivroBuscar(); break;
            //Leitura
            case 07 : LeituraListar(); break;
            case 8 : LeituraExcluir(); break;
            //Senha
            case 10: MudarSenha(); break;
          }
      }
      catch (Exception erro) {
        Console.WriteLine(erro.GetType() + "\n" + erro.Message);      
      }
    } while (op != 99);
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
    Console.WriteLine("⣿  05 - Listar Livros     ⣿");
    Console.WriteLine("⣿  06 - Buscar Livro      ⣿");
    Cor.DarkRed(); 
    Console.WriteLine("∷∷∷∷∷∷∷∷【LEITURA】∷∷∷∷∷∷∷∷"); 
    Cor.DarkBlue();
    Console.WriteLine("⣿  07 - Listar Leitura    ⣿");
    Console.WriteLine("⣿  08 - Excluir Leitura   ⣿");
    Console.WriteLine("∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷∷");
    Console.WriteLine("⣿  10 - Mudar Senha       ⣿");
    Console.WriteLine("⣿  99 - Logout            ⣿");
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
            case 13 : UsuarioListar(); break;
            case 14 : UsuarioExcluir(); break;
          }
      }
      catch (Exception erro) {
        Console.WriteLine(erro.GetType() + "\n" + erro.Message);      
      }
    } while (op != 99);
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
    Console.WriteLine("⣿  99 - Logout            ⣿");
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
    if(busca=="0") MainLeitor(); 
    Genero g = NGenero.Buscar(busca);
    if(g==null){
      Cor.DarkRed();
      Console.WriteLine("Gênero não encontrado ✘");
      Cor.White();
      Console.WriteLine("Deseja fazer uma nova busca: S/N ");
      string resp = Console.ReadLine();
      if(resp.ToUpper() == "N") MainLeitor();
      GeneroBuscar();
    }     
    Cor.Magenta();
    Console.WriteLine(g);
    Cor.White();
    Console.Write("▶ Deseja Listar os Livros\n  do Gênero? S/N ");
    string res = Console.ReadLine();
    if(res.ToUpper() == "N".ToUpper()) GeneroBuscar();
    if(res.ToUpper() == "S"){
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
    nova.Situacao = true;
    nova.DataInicio = DateTime.Today;
    NLeitura.Inserir(nova);
    
    Cor.Green();
    Console.WriteLine("Livro Selecionado ✔"); 
    Cor.White();
    Console.WriteLine("———————————————————————————");
    }
    else{
      Cor.DarkRed();
      Console.WriteLine("Comando Inválido ✘");
      Cor.White();
      Console.WriteLine("———————————————————————————");
      GeneroBuscar();
    }
    }
    catch(ArgumentOutOfRangeException){
      Cor.DarkRed();
      Console.WriteLine("Livro Já Selecionado ✘");
      Cor.White();
      Console.WriteLine("———————————————————————————");
      GeneroBuscar();
    }
    
    Console.WriteLine("———————————————————————————");
  }
  
  public static void UsuarioGeneroListar(){
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
      nova.Situacao = true;
      nova.DataInicio = DateTime.Today;
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
      UsuarioGeneroListar();
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


  /*==================TRATAMENTO DE LIVRO=====================*/

  public static void UsuarioLivroBuscar(){
    try{
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷【BUSCAR LIVRO】∷∷∷∷∷");
    Cor.White();
    Console.Write("▶ Digite Sua Busca 🔎 ou 0\n  para sair: ");
    string busca = Console.ReadLine();
    if(busca=="0") MainLeitor();
    Livro a = NLivro.Buscar(busca);
    if(a==null){
      Cor.DarkRed();
      Console.WriteLine("Livro não encontrado ✘");
      Cor.White();
      Console.Write("▶ Deseja fazer uma nova busca: S/N ");
      string resp = Console.ReadLine();
      if(resp.ToUpper() == "N".ToUpper()) MainLeitor();
      UsuarioLivroBuscar();
    }
    Cor.Magenta();
    Console.WriteLine($"{a.Id} - {a.Titulo} - Autor: {NAutor.Pesquisar(a.IdAutor).Nome} - Gênero: {NGenero.Pesquisar(a.IdGenero).Descricao}");
    Cor.White();          
    Console.Write("▶ Deseja Adicionar Livro a Leitura? S/N: ");
    string r = Console.ReadLine();
    if(r.ToUpper()=="N"){ 
      Cor.White();
      Console.WriteLine("———————————————————————————");
      MainLeitor();
    }
    if(r.ToUpper()=="S"){  
    Leitura nova = new Leitura();
    nova.IdLivro = a.Id;
    nova.IdUsuario = leitorLogado.Id;
    nova.Situacao = true;
    nova.DataInicio = DateTime.Today;
    NLeitura.Inserir(nova);
    Cor.Green();
    Console.WriteLine("Livro Selecionado ✔"); 
    Cor.White();
    Console.WriteLine("———————————————————————————");
    }
    else{
     Cor.DarkRed();
     Console.WriteLine("Comando Inválido ✘");
     Cor.White();
     Console.WriteLine("———————————————————————————"); 
     UsuarioLivroBuscar();          }
    }
    catch(ArgumentOutOfRangeException){
      Cor.DarkRed();
      Console.WriteLine("Livro Já Selecionado ✘");
      Cor.White();
      Console.WriteLine("———————————————————————————");
      UsuarioLivroBuscar();
    }
    
    Console.WriteLine("———————————————————————————");
  }
  
  public static void UsuarioLivroListar(){
    try{
    Cor.White();          
    Console.WriteLine("———————————————————————————");  
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷∷∷∷∷【LIVROS】∷∷∷∷∷∷∷∷");
    Cor.Magenta();
    foreach(Livro i in NLivro.Listar())
      Console.WriteLine($"{i.Id} - {i.Titulo} - Gênero: {NGenero.Pesquisar(i.IdGenero).Descricao}");
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
    nova.Situacao = true;
    nova.DataInicio = DateTime.Today;
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
      UsuarioLivroListar();
    }
  }
  
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
   try{ Console.WriteLine("———————————————————————————");
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷∷∷∷∷【LIVROS】∷∷∷∷∷∷∷∷");
    Cor.Magenta();
    foreach(Livro i in NLivro.Listar())
      Console.WriteLine($"{i.Id} - {i.Titulo} - Autor: {NAutor.Pesquisar(i.IdAutor).Nome} - Gênero: {NGenero.Pesquisar(i.IdGenero).Descricao}");
    Cor.White();
    Console.WriteLine("———————————————————————————");
  }
    catch(NullReferenceException){
      Cor.DarkRed();
      Console.WriteLine("Livros não encontrado ✘");
      Cor.White();
    }
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
   try{ Console.WriteLine("———————————————————————————");
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
    catch(NullReferenceException){
      Cor.DarkRed();
      Console.WriteLine("Livro não encontrado ou não existem livros ✘");
      Cor.White();
    }
  }

  /*===============TRATAMENTO DE AUTOR================*/
  public static void AutorBuscar(){
    try{
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷【BUSCAR AUTOR】∷∷∷∷∷");
    Cor.White();
    Console.Write("▶ Digite Sua Busca 🔎 ou 0\n  para sair: ");
    string busca = Console.ReadLine();
    if(busca.ToUpper() == "0") MainLeitor();
    Autor a = NAutor.Buscar(busca);
    if(a==null){
      Cor.DarkRed();
      Console.WriteLine("Autor não encontrado ✘");
      Cor.White();
      Console.WriteLine("Deseja fazer uma nova busca: S/N ");
      string resp = Console.ReadLine();
      if(resp.ToUpper() == "N") MainLeitor();
      AutorBuscar();
    }
    Cor.Magenta();
    Console.WriteLine(a);
    Cor.White();
    Console.Write("▶ Deseja Listar os Livros\n  do Autor? S/N ");
    string res = Console.ReadLine();
    if(res.ToUpper() == "N") AutorBuscar();
    if(res.ToUpper() == "S"){
      Cor.White();          
      Console.WriteLine("———————————————————————————");  
      Cor.Yellow();
      Console.WriteLine("∷∷∷∷∷∷∷∷∷【LIVROS】∷∷∷∷∷∷∷∷");
      Cor.Magenta();
      foreach(Livro i in NLivro.ListarLivroAutor(a))
      Console.WriteLine($"{i.Id} - {i.Titulo} - Gênero: {NGenero.Pesquisar(i.IdGenero).Descricao}");
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
      nova.Situacao = true;
      nova.DataInicio = DateTime.Today;
      NLeitura.Inserir(nova);
      
      Cor.Green();
      Console.WriteLine("Livro Selecionado ✔"); 
      Cor.White();
      Console.WriteLine("———————————————————————————");
    }
    else{
     Cor.DarkRed();
     Console.WriteLine("Comando Inválido ✘");
     Cor.White();
     Console.WriteLine("———————————————————————————"); 
     AutorBuscar();
    }
    }
    catch(ArgumentOutOfRangeException){
      Cor.DarkRed();
      Console.WriteLine("Livro Já Selecionado ✘");
      Cor.White();
      Console.WriteLine("———————————————————————————");
      AutorBuscar();
    }
    
    Console.WriteLine("———————————————————————————");
  }
  
  public static void UsaurioAutorListar(){
    try{
    AutorListar();
    Console.Write("▶ Qual Autor: ");
    int id = int.Parse(Console.ReadLine());
    Autor a = NAutor.Pesquisar(id);
    Cor.White();          
    Console.WriteLine("———————————————————————————");  
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷∷∷∷∷【LIVROS】∷∷∷∷∷∷∷∷");
    Cor.Magenta();
    foreach(Livro i in NLivro.ListarLivroAutor(a))
      Console.WriteLine($"{i.Id} - {i.Titulo} - Gênero: {NGenero.Pesquisar(i.IdGenero).Descricao}");
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
      nova.Situacao = true;
      nova.DataInicio = DateTime.Today;
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
      UsaurioAutorListar();
    }
  }
  
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

  
  /*============TRATAMENTO DE USUARIO ===========*/
  public static void UsuarioListar(){
    try{
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷∷∷【LEITORES】∷∷∷∷∷∷∷∷");
    Cor.Magenta();
    foreach(Usuario i in NUsuario.Listar())
      Console.WriteLine($"{i.Id} - {i.Nome}");
    Cor.White();
    Console.WriteLine("———————————————————————————");
    }
    catch(NullReferenceException){
      Cor.DarkRed();
      Console.WriteLine("Não tem Usuários Cadastrados ✘");
      Cor.White();
      Console.WriteLine("———————————————————————————");
      MainAdmin();
    }
    
  }
  public static void UsuarioExcluir(){
    try{
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷【EXCLUIR LEITOR】∷∷∷∷");
    Cor.Magenta();
    foreach(Usuario i in NUsuario.Listar())
      Console.WriteLine($"{i.Id} - {i.Nome}");
    Cor.White();
    Console.Write("▶ Id: ");
    int id = int.Parse(Console.ReadLine());
    Usuario x = NUsuario.Pesquisar(id);
    NUsuario.Excluir(x);
    Console.WriteLine("Leitor Excluído ✔");
    Cor.White();
    Console.WriteLine("———————————————————————————");
    }
    catch(NullReferenceException){
      Cor.DarkRed();
      Console.WriteLine("Não tem Usuários Cadastrados ✘");
      Cor.White();
      Console.WriteLine("———————————————————————————");
      MainAdmin();
    }
  }

  public static void MudarSenha(){
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷【MUDAR SENHA】∷∷∷∷∷∷");
    Cor.White();
    Console.Write("▶ Digite sua nova senha: ");
    string novaSenha = Console.ReadLine();
    Usuario x = NUsuario.Pesquisar(leitorLogado.Id);
    x.Senha = novaSenha;
    NUsuario.Atualizar(x);
    Cor.Green();
    Console.WriteLine("Senha Alterada ✔");
  }
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
    u.Nome = nome;
    u.NomeUsuario = nomeusuario;
    u.Senha = senha;
    NUsuario.Inserir(u);
    
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


  /*==========================TRATAMENTO DE LEITUTA==================*/
  public static void LeituraListar(){
    try{
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷【SUAS LEITURAS】∷∷∷∷");
    foreach(Leitura i in NLeitura.ListarLeituraUsuario(leitorLogado)){
      if(i.Situacao){
        Cor.Magenta();
        Console.Write($"{i.Id} - {NLivro.Pesquisar(i.IdLivro).Titulo}");
        Cor.Green();
        Console.Write($" Aberto");
        Cor.Magenta();
        Console.WriteLine($" {i.DataInicio:dd/MM}");
      }
      else{
        Cor.Magenta();
        Console.Write($"{i.Id} - {NLivro.Pesquisar(i.IdLivro).Titulo}");
        Cor.DarkRed();
        Console.Write($" Fechado");
        Cor.Magenta();
        Console.WriteLine($" {i.DataInicio:dd/MM}");
      }
    }
    Cor.White();
    Console.WriteLine("———————————————————————————");
    Console.WriteLine("1 - Fechar Leitura");
    Console.WriteLine("2 - Abrir Leitura");
    Console.WriteLine("0 - Voltar");
    Console.WriteLine("———————————————————————————");  
    Console.Write("▶ Opção: ");
    string resp = Console.ReadLine();
    if(resp=="0") MainLeitor();
    if(resp=="1"){
      Console.Write("▶ Id da Leitura: ");
      int idleitura = int.Parse(Console.ReadLine());
      Leitura x = NLeitura.Pesquisar(idleitura);
      if(!x.Situacao){
        Cor.DarkRed();
        Console.WriteLine("Leitura já fechada ✘");
        Cor.White();
        Console.WriteLine("———————————————————————————");
        LeituraListar();
      }
      x.Situacao = false;
      x.DataFim = DateTime.Today;
      NLeitura.Atualizar(x);
      Cor.Green();
      Console.WriteLine("Leitura Fechada ✔");
      Cor.White();
      Console.WriteLine("———————————————————————————");
      LeituraListar();
    }
    if(resp=="2"){
      Console.Write("▶ Id da Leitura: ");
      int idleitura = int.Parse(Console.ReadLine());
      Leitura x = NLeitura.Pesquisar(idleitura);
      if(x.Situacao){
        Cor.DarkRed();
        Console.WriteLine("Leitura já Aberta ✘");
        Cor.White();
        Console.WriteLine("———————————————————————————");
        LeituraListar();
      }
      x.Situacao = true;
      x.DataInicio = DateTime.Today;
      NLeitura.Atualizar(x);
      Cor.Green();
      Console.WriteLine("Leitura Aberta ✔");
      Cor.White();
      Console.WriteLine("———————————————————————————");
      LeituraListar();
    }
    else{
      Cor.DarkRed();
      Console.WriteLine("Comando Inválido ✘");
      Cor.White();
      Console.WriteLine("———————————————————————————");
      LeituraListar();
    }
    Cor.White();
    Console.WriteLine("———————————————————————————");
    }
    catch(NullReferenceException){
      Cor.DarkRed();
      Console.WriteLine("Leitura não encontrada ou não existem leituras ✘");
      Cor.White();
      Console.WriteLine("———————————————————————————");
      //LeituraListar();
      MainLeitor();
    }
  }

  public static void LeituraExcluir(){
    try{
    Cor.Yellow();
    Console.WriteLine("∷∷∷∷∷【EXCLUIR LEITURA】∷∷∷∷");
    Cor.Magenta();
    foreach(Leitura i in NLeitura.Listar())
      Console.WriteLine($"{i.Id} - {NLivro.Pesquisar(i.IdLivro).Titulo} - Autor {NAutor.Pesquisar(NLivro.Pesquisar(i.IdLivro).IdAutor).Nome} - Gênero: {NGenero.Pesquisar(NLivro.Pesquisar(i.IdLivro).IdGenero).Descricao}");
    Cor.White();
    Console.Write("▶ Id da Leitura: ");
    int idleitura = int.Parse(Console.ReadLine());
    Leitura x = NLeitura.Pesquisar(idleitura);
    NLeitura.Excluir(x);
    Cor.Green();
    Console.WriteLine("Leitura Excluída ✔");
    Cor.White();
    Console.WriteLine("———————————————————————————");
    }
    catch(NullReferenceException){
      Cor.DarkRed();
      Console.WriteLine("Leitura não encontrada ou não existem leituras ✘");
      Cor.White();
      Console.WriteLine("———————————————————————————");
      //LeituraExcluir();
    }
  }
}