using System;
using System.Collections.Generic;
using System.Linq;

class NAutor{
  private List<Autor> autores = new List<Autor>();
  public void Inserir(Autor obj){
    int id = 0;
    foreach(Autor i in autores)
      if(i.Id > id) id = i.Id;
    id++;
    obj.Id = id;
    autores.Add(obj);
  }
  public List<Autor> Listar(){
    return autores.OrderBy(obj => obj.Nome).ToList();
  }
  public void Atualizar(Autor obj){
    foreach(Autor i in autores)
      if(i.Id == obj.Id){
        i.Nome = obj.Nome;
      }
  }
  public void Excluir(Autor obj){
    Autor x = new Autor();
    foreach(Autor i in autores)
      if(i.Id == obj.Id)
        x = i;
    autores.Remove(x);
  }
}