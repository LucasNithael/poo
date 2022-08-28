using System;
using System.Collections.Generic;
using System.Linq;

static class NLivro{
  private static List<Livro> livros = new List<Livro>();
  public static void Inserir(Livro obj){
    int id = 0;
    foreach(Livro i in livros)
      if(i.Id > id) id = i.Id;
    id++;
    obj.Id = id;
    livros.Add(obj);
  }
  public static List<Livro> Listar(){
    return livros.OrderBy(obj => obj.Id).ToList();
  }
  public static void Atualizar(Livro obj){
    Livro x = Pesquisar(obj.Id);
    x.Titulo = obj.Titulo;
  }
  public static void Excluir(Livro obj){
    Livro x = Pesquisar(obj.Id);
    livros.Remove(x);
  }
  public static Livro Pesquisar(int id){
    foreach(Livro i in livros)
      if(i.Id == id) return i;
    return null;
  }
  public static List<Livro> ListarLivroGenero(Genero g){
    List<Livro> r = new List<Livro>();
    foreach(Livro i in livros)
      if(i.IdGenero == g.Id)
        r.Add(i);
    return r;
  }
}