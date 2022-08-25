using System;
using System.Collections.Generic;
using System.Linq;

static class NGenero{
  private static List<Genero> generos = new List<Genero>();
  public static void Inserir(Genero g){
    int id = 0;
    foreach(Genero i in generos)
      if(i.Id > id) id = i.Id;
    id++;
    g.Id = id;
    generos.Add(g);
  }
  public static List<Genero> Listar(){
    return generos.OrderBy(obj => obj.Id).ToList();
  }
  public static void Atualizar(Genero g){
    Genero x = Pesquisar(g.Id);
        x.Descricao = g.Descricao;
      
  }
  public static void Excluir(Genero g){
    Genero x = Pesquisar(g.Id);
    generos.Remove(x);
  }
  public static Genero Pesquisar(int id){
    foreach(Genero i in generos){
      if(i.Id == id) return i;
    }
    return null;
  }
}