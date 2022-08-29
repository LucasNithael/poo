using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.IO;

static class NLeitor{
  private static List<Leitor> leitores;
  public static void Inserir(Leitor l){
    leitores = Abrir();
    int id = 0;
    foreach(Leitor i in leitores)
      if(i.Id > id) id = i.Id;
    id++;
    l.Id = id;
    leitores.Add(l);
    Salvar(leitores);
  }
  public static List<Leitor> Listar(){
    leitores = Abrir();
    if(leitores.Count == 0) throw new NullReferenceException("Não existe leitores");
     return leitores;
    
  }
  public static void Atualizar(Leitor l){
    Leitor x = Pesquisar(l.Id);
    x.Nome = l.Nome;
    Salvar(leitores);
      
  }
  public static void Excluir(Leitor l){
    Leitor x = Pesquisar(l.Id);
    if(x != null){
      leitores.Remove(x);
      Salvar(leitores);
    }
  }
  public static Leitor Pesquisar(int id){
    foreach(Leitor i in Listar())
      if(i.Id == id) return i;
    return null;
  }
  
  private static string arquivo = "Arquivos/leitores.xml";
  
  private static List<Leitor> Abrir() {
    XmlSerializer xml = new XmlSerializer(typeof(List<Leitor>));
    StreamReader f = null;
    List<Leitor> obj;
    try {
      f = new StreamReader(arquivo);
      obj = (List<Leitor>) xml.Deserialize(f);
    }
    catch(FileNotFoundException) {
      obj = new List<Leitor>();
    }
    finally {
     if (f != null) f.Close();
    }
    return obj;
  }
  private static void Salvar(List<Leitor> obj) {
    XmlSerializer xml = new
      XmlSerializer(typeof(List<Leitor>));
    StreamWriter f = new StreamWriter(arquivo, false);
    xml.Serialize(f, obj);
    f.Close();
  }
}