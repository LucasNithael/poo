using System;
using System.Collections.Generic;

static class NProduto{
  private static List<Produto> produtos = new List<Produto>();
  public static void Inserir(Produto c) {
    int id = 0;
    foreach(Produto obj in produtos)
      if(obj.Id > id) id = obj.Id;
    id++;
    c.Id = id;
    produtos.Add(c);
  }
  public static List<Produto> Listar() {
    return produtos;
  }
  public static Produto Listar(int id) {
    foreach(Produto obj in produtos)
      if (obj.Id == id) return obj;
    return null;
  }
  public static void Atualizar(Produto c) {
    Produto atual = Listar(c.Id);
    if (atual != null){ 
      atual.Descricao = c.Descricao;
      atual.Preco = c.Preco;
    }
  }
  public static void Excluir(Produto c) {
    Produto atual = Listar(c.Id);
    if (atual != null) 
      produtos.Remove(atual);
  }
}