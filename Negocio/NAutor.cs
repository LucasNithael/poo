using System;
using System.Collections.Generic;
using System.Linq;

static class NAutor{
  private  static List<Autor> autores = new List<Autor>();
  public static void Inserir(Autor obj){
    int id = 0;
    foreach(Autor i in autores)
      if(i.Id > id) id = i.Id;
    id++;
    obj.Id = id;
    autores.Add(obj);
  }
  public static List<Autor> Listar(){
    return autores.OrderBy(obj => obj.Id).ToList();
  }
  public static void Atualizar(Autor obj){
    Autor x = Pesquisar(obj.Id);
    x.Nome = obj.Nome;
  }
  public static void Excluir(Autor obj){
    Autor x = Pesquisar(obj.Id);
    autores.Remove(x);
  }
  public static Autor Pesquisar(int id){
    foreach(Autor i in autores)
      if(i.Id == id) return i;
    return null;
  }
}