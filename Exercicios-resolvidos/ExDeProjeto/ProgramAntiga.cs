using System;

class Program {
  public static bool AdminLogado = false;
  public static Cliente = null
  public static void Main() {
    Console.WriteLine("--- Bem-vindo ao IFShop ---");
    Console.WriteLine();
    int op = 0;
    do {
      try {
        op = Menu();
        switch (op) {
            case 01 : CategoriaInserir(); break;
            case 02 : CategoriaListar(); break;
            case 03 : CategoriaAtualizar(); break;
            case 04 : CategoriaExcluir(); break;
            case 05 : ProdutoInserir(); break;
            case 06 : ProdutoListar(); break;
            case 07 : ProdutoAtualizar(); break;
            case 08 : ProdutoExcluir(); break;
          }
      }
      catch (Exception erro) {
        Console.WriteLine(erro.Message);      
      }
    } while (op != 99);
  }
  public static int Menu() {
    Console.WriteLine("----- Categorias -----");
    Console.WriteLine("  01 - Inserir");
    Console.WriteLine("  02 - Listar");
    Console.WriteLine("  03 - Atualizar");
    Console.WriteLine("  04 - Excluir");
    Console.WriteLine("----- Produto -----");
    Console.WriteLine("  05 - Inserir");
    Console.WriteLine("  06 - Listar");
    Console.WriteLine("  07 - Atualizar");
    Console.WriteLine("  08 - Excluir");
    Console.WriteLine("----------------------");
    Console.WriteLine("  99 - Fim");
    Console.WriteLine("----------------------");
    Console.Write("Opção: ");
    return int.Parse(Console.ReadLine());    
  }
  public static void CategoriaInserir() {
    Console.WriteLine("----- Categoria Inserir -----");

    //Console.WriteLine("Informe o id da categoria");
    //int id = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe a descrição da categoria");
    string desc = Console.ReadLine();

    Categoria c = new Categoria();
    //c.Id = id;
    c.Descricao = desc;

    NCategoria.Inserir(c);

    Console.WriteLine("Categoria inserida com sucesso");
  }
  public static void CategoriaListar() {
    Console.WriteLine("----- Categoria Listar -----");
    foreach(Categoria obj in NCategoria.Listar())
      Console.WriteLine(obj);
  }
  public static void CategoriaAtualizar() {
    Console.WriteLine("----- Categoria Atualizar -----");

    foreach(Categoria obj in NCategoria.Listar())
      Console.WriteLine(obj);
    
    Console.WriteLine("Informe o id da categoria a ser atualizada");
    int id = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe a nova descrição da categoria");
    string desc = Console.ReadLine();
    
    Categoria c = new Categoria();
    c.Id = id;
    c.Descricao = desc;

    NCategoria.Atualizar(c);

    Console.WriteLine("Categoria atualizada com sucesso");
  }
  public static void CategoriaExcluir() {
    Console.WriteLine("----- Categoria Excluir -----");
    foreach(Categoria obj in NCategoria.Listar())
      Console.WriteLine(obj);

    Console.WriteLine("Informe o id da categoria a ser excluída");
    int id = int.Parse(Console.ReadLine());
    
    Categoria c = new Categoria();
    c.Id = id;

    NCategoria.Excluir(c);

    Console.WriteLine("Categoria excluída com sucesso");
  }



  public static void ProdutoInserir() {
    Console.WriteLine("----- Produto Inserir -----");
    Console.WriteLine("Informe a descrição do produto");
    string desc = Console.ReadLine();
    Console.WriteLine("Informe o preço do produto");
    double preco = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe o estoque do produto");
    int estoque = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe o Id da categoria do produto");
    foreach(Categoria obj in NCategoria.Listar())
      Console.WriteLine(obj);
    Console.Write("Ops: ");
    int idcatg = int.Parse(Console.ReadLine());
    
    Produto p = new Produto();
    p.Descricao = desc;
    p.Preco = preco;
    p.Estoque = estoque;
    p.IdCategoria = idcatg;

    NProduto.Inserir(p);

    Console.WriteLine("Produto inserido com sucesso");
  }
  public static void ProdutoListar() {
    Console.WriteLine("----- Produto Listar -----");
    foreach(Produto obj in NProduto.Listar())
      Console.WriteLine(obj + NCategoria.Listar(obj.IdCategoria).Descricao);
  }
  public static void ProdutoAtualizar() {
    Console.WriteLine("----- Produto Atualizar -----");

    foreach(Produto obj in NProduto.Listar())
      Console.WriteLine(obj);
    
    Console.WriteLine("Informe o id da produto a ser atualizada");
    int id = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe a nova descrição do produto");
    string desc = Console.ReadLine();
    Console.WriteLine("Informe o novo preço do produto");
    double preco = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe o novo estoque do produto");
    int estoque = int.Parse(Console.ReadLine());
    
    Produto p = new Produto();
    p.Id = id;
    p.Descricao = desc;
    p.Preco = preco;
    p.Estoque = estoque;
    
    NProduto.Atualizar(p);

    Console.WriteLine("Produto atualizado com sucesso");
  }
  public static void ProdutoExcluir() {
    Console.WriteLine("----- Produto Excluir -----");
    foreach(Produto obj in NProduto.Listar())
      Console.WriteLine(obj);

    Console.WriteLine("Informe o id do produto a ser excluído");
    int id = int.Parse(Console.ReadLine());
    
    Produto p = new Produto();
    p.Id = id;

    NProduto.Excluir(p);

    Console.WriteLine("Produto excluído com sucesso");
  }
}