using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.IO;

static class NLeitura{
  public static List<Leitura> leituras;
  public static void Inserir(Leitura l){
      leituras = Abrir();
      foreach(Leitura i in leituras)
        if(i.IdLivro==l.IdLivro) throw new ArgumentOutOfRangeException("Livro já foi escolhido");
      int id = 0;
      foreach(Leitura i in leituras)
        if(i.Id > id) id = i.Id;
      id++;
      l.Id = id;
      leituras.Add(l);
      Salvar(leituras);
  }
  public static List<Leitura> ListarLeituraUsuario(Usuario u){
    leituras = Abrir();
    List<Leitura> leiturasU = new List<Leitura>();
    if(leituras.Count == 0) throw new NullReferenceException("Não existe Leitura");
    foreach(Leitura i in leituras)
      if(i.IdUsuario == u.Id)
        leiturasU.Add(i);
    return leiturasU;
  }

  public static List<Leitura> Listar(){
    leituras = Abrir();
    if(leituras.Count == 0) throw new NullReferenceException("Não existe Leitura");
    return leituras;
  }

  public static void Atualizar(Leitura l){
    Leitura x = Pesquisar(l.Id);
    x.Situacao = l.Situacao;
    x.DataFim = l.DataFim;
    Salvar(leituras);   
  }

  public static Leitura Pesquisar(int id){
    foreach(Leitura i in Listar())
      if(i.Id == id) return i;
    return null;
  }

  public static void Excluir(Leitura l){
    Leitura x = Pesquisar(l.Id);
    if(x != null){
      leituras.Remove(x);
      Salvar(leituras);
    }
  }
  
  private static string arquivo = "Arquivos/leituras.xml";

  private static List<Leitura> Abrir() {
    try {
        return Arquivo<List<Leitura>>.Abrir(arquivo);
    }
    catch(FileNotFoundException) {
      return new List<Leitura>();
    }
  }
  
  private static void Salvar(List<Leitura> obj) {
    Arquivo<List<Leitura>>.Salvar(arquivo, obj);
  }
}