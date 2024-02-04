using System;
using System.Collections.Generic;

class NUsuario{
  public static List<Usuario> usuarios = new List<Usuario>();
  public static int Inserir(Usuario u){
    int id = 0;
    foreach(Usuario obj in usuarios)
      if(obj.Id > id) id = obj.Id;
    id++;
    u.Id = id;
    usuarios.Add(u);
    return id;
  }
  public static Usuario Autenticar(string nome, string senha){
    foreach(Usuario i in usuarios)
      if(i.Nome==nome && i.Senha==senha)
        return i;
    return null;
  }
}