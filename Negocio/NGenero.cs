using System;
using System.Collections.Generic;
using System.Linq;

class NGenero{
  private List<Genero> generos = new List<Genero>();
  public void Inserir(Genero g){
    int id = 0;
    foreach(Genero i in generos)
      if(i.Id > id) id = i.Id;
    id++;
    g.Id = id;
    generos.Add(g);
  }
  public List<Genero> Listar(){
    return generos.OrderBy(obj => obj.Descricao).ToList();
  }
  public void Atualizar(Genero g){
    foreach(Genero i in generos)
      if(i.Id == g.Id){
        i.Descricao = g.Descricao;
      }
  }
  public void Excluir(Genero g){
    Genero x = new Genero();
    foreach(Genero i in generos)
      if(i.Id == g.Id)
        x = i;
    generos.Remove(x);
  }
}