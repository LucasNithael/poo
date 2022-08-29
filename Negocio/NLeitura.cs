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
  public static List<Leitura> Listar(){
    leituras = Abrir();
    if(leituras.Count == 0) throw new NullReferenceException("Não existe Gêneros");
    else return leituras;
  }
  
  private static string arquivo = "Arquivos/leituras.xml";

  private static List<Leitura> Abrir() {
    XmlSerializer xml = new XmlSerializer(typeof(List<Leitura>));
    StreamReader f = null;
    List<Leitura> obj;
    try {
      f = new StreamReader(arquivo);
      obj = (List<Leitura>) xml.Deserialize(f);
    }
    catch(FileNotFoundException) {
      obj = new List<Leitura>();
    }
    finally {
     if (f != null) f.Close();
    }
    return obj;
  }
  private static void Salvar(List<Leitura> obj) {
    XmlSerializer xml = new
      XmlSerializer(typeof(List<Leitura>));
    StreamWriter f = new StreamWriter(arquivo, false);
    xml.Serialize(f, obj);
    f.Close();
  }
}