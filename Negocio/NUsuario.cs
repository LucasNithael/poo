using System;
using System.Collections.Generic;

static class NUsuario{
  public static List<Usuario> usuarios = new List<Usuario>();
  public static void Inserir(Usuario u){
    foreach(Usuario i in usuarios)
      if(i.NomeUsuario==u.NomeUsuario) throw new ArgumentOutOfRangeException("Usuário já existe");
    int id = 0;
    foreach(Usuario i in usuarios)
      if(i.Id > id) id = i.Id;
    id++;
    u.Id = id;
    usuarios.Add(u);
  }
  public static void Autenticar(Usuario u){
    
  }
}