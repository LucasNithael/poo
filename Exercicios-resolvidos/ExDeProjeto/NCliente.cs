using System;
using System.Collections.Generic;

class NCliente{
  public static List<Cliente> clientes = new List<Cliente>();
  public static int Inserir(Cliente c){
    int id = 0;
    foreach(Cliente obj in clientes)
      if(obj.Id > id) id = obj.Id;
    id++;
    c.Id = id;
    clientes.Add(c);
    return id;
  }
  public static Cliente Listar(int IdUsuario){
    foreach(Cliente i in clientes)
      if(IdUsuario == i.IdUsuario)
        return i;
    return null;
  }
}