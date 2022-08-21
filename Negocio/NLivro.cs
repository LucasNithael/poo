using System;
using System.Collections.Generic;
using System.Linq;

class NLivro{
  private List<Livro> livros = new List<Livro>();
  public void Inserir(Livro obj){
    int id = 0;
    foreach(Livro i in livros)
      if(i.Id > id) id = i.Id;
    id++;
    obj.Id = id;
    livros.Add(obj);
  }
  public List<Livro> Listar(){
    return livros.OrderBy(obj => obj.Titulo).ToList();
  }
  public void Atualizar(Livro obj){
    foreach(Livro i in livros)
      if(i.Id == obj.Id){
        i.Titulo = obj.Titulo;
        i.SetAnoLancamento(obj.GetAnoLancamento());
      }
  }
  public void Excluir(Livro obj){
    Livro x = new Livro();
    foreach(Livro i in livros)
      if(i.Id == obj.Id)
        x = i;
    livros.Remove(x);
  }
}