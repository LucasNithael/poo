using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.IO;

static class NUsuario{
  public static List<Usuario> usuarios;
  
  public static void Inserir(Usuario u){
    if(u.NomeUsuario != "admin" && u.Senha != "admin"){
      usuarios = Abrir();
      foreach(Usuario i in usuarios)
        if(i.NomeUsuario==u.NomeUsuario) throw new ArgumentOutOfRangeException("Usuário já existe");
      int id = 0;
      foreach(Usuario i in usuarios)
        if(i.Id > id) id = i.Id;
      id++;
      u.Id = id;
      usuarios.Add(u);
      Salvar(usuarios);}
  }

  public static List<Usuario> Listar(){
    usuarios = Abrir();
    if(usuarios.Count == 0) throw new NullReferenceException("Não existe Usuários");
    else return usuarios;
  }
  public static void Atualizar(Usuario u){
    Usuario x = Pesquisar(u.Id);
    x.Senha = u.Senha;
    Salvar(usuarios);
      
  }
  public static void Excluir(Usuario u){
    Usuario x = Pesquisar(u.Id);
    if(x != null){
      usuarios.Remove(x);
      Salvar(usuarios);
    }
  }
  public static Usuario Pesquisar(int id){
    foreach(Usuario i in Listar())
      if(i.Id == id) return i;
    return null;
  }
  
  public static Usuario Autenticar(string usuario, string senha){
    usuarios = Abrir();
    foreach(Usuario i in usuarios)
      if(i.NomeUsuario == usuario && i.Senha == senha)
        return i;
    return null;
  }

  private static string arquivo = "Arquivos/usuarios.xml";

  private static List<Usuario> Abrir() {
    XmlSerializer xml = new XmlSerializer(typeof(List<Usuario>));
    StreamReader f = null;
    List<Usuario> obj;
    try {
      f = new StreamReader(arquivo);
      obj = (List<Usuario>) xml.Deserialize(f);
    }
    catch(FileNotFoundException) {
      obj = new List<Usuario>();
    }
    finally {
     if (f != null) f.Close();
    }
    return obj;
  }
  private static void Salvar(List<Usuario> obj) {
    XmlSerializer xml = new
      XmlSerializer(typeof(List<Usuario>));
    StreamWriter f = new StreamWriter(arquivo, false);
    xml.Serialize(f, obj);
    f.Close();
  }
}