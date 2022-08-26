using System;
using System.Collections.Generic;
using System.Linq;

static class NLeitor{
  private static List<Leitor> leitores = new List<Leitor>();
  public static void Inserir(Leitor l){
    int id = 0;
    foreach(Leitor i in leitores)
      if(i.Id > id) id = i.Id;
    id++;
    l.Id = id;
    leitores.Add(l);
  }
  public static List<Leitor> Listar(){
    return leitores.OrderBy(obj => obj.Id).ToList();
  }
  public static void Atualizar(Leitor l){
    Leitor x = Pesquisar(l.Id);
        x.Nome = l.Nome;
      
  }
  public static void Excluir(Leitor l){
    Leitor x = Pesquisar(l.Id);
    leitores.Remove(x);
  }
  public static Leitor Pesquisar(int id){
    foreach(Leitor i in leitores)
      if(i.Id == id) return i;
    return null;
  }
}