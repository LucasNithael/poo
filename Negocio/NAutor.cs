using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.IO;

static class NAutor{
  private  static List<Autor> autores;
  public static void Inserir(Autor obj){
    autores = Abrir();
    int id = 0;
    foreach(Autor i in autores)
      if(i.Id > id) id = i.Id;
    id++;
    obj.Id = id;
    autores.Add(obj);
    Salvar(autores);
  }
  public static List<Autor> Listar(){
    autores = Abrir();
    if(autores.Count == 0) throw new NullReferenceException("Não há Autores Cadastrados");
    else return autores;
  }
  public static void Atualizar(Autor obj){
    Autor x = Pesquisar(obj.Id);
    x.Nome = obj.Nome;
    Salvar(autores);
  }
  public static void Excluir(Autor obj){
    Autor x = Pesquisar(obj.Id);
    autores.Remove(x);
    Salvar(autores);
  }
  public static Autor Pesquisar(int id){
    foreach(Autor i in Listar())
      if(i.Id == id) return i;
    return null;
  }

  //Métodos de arquivos
  private static string arquivo = "Arquivos/autores.xml";
  
  private static List<Autor> Abrir() {
    XmlSerializer xml = new XmlSerializer(typeof(List<Autor>));
    StreamReader f = null;
    List<Autor> obj;
    try {
      f = new StreamReader(arquivo);
      obj = (List<Autor>) xml.Deserialize(f);
    }
    catch(FileNotFoundException) {
      obj = new List<Autor>();
    }
    finally {
     if (f != null) f.Close();
    }
    return obj;
  }
  private static void Salvar(List<Autor> obj) {
    XmlSerializer xml = new
      XmlSerializer(typeof(List<Autor>));
    StreamWriter f = new StreamWriter(arquivo, false);
    xml.Serialize(f, obj);
    f.Close();
  }
}