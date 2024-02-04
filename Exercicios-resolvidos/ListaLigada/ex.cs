using System;

class Program {
  public static void Main() {
    /*
    Item a = new Item("TADS");
    Item b = new Item("Redes");
    Item c = new Item("InfoWeb");
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    a.SetProx(b);
    b.SetProx(c);
    Item aux = a;
    while (aux != null) {
      Console.WriteLine(aux);
      aux = aux.GetProx();
    }
    */
    Lista l = new Lista();      // l = []
    l.Inserir("TADS");          // l.append("TADS")
    l.Inserir("Redes");
    l.Inserir("InfoWeb");
    l.Inserir("Gestão");
    l.Inserir("Manutenção");
    l.Imprimir();
  }
}
class Lista {
  private Item primeiro, ultimo;
  public void Inserir(string valor) {
    Item novo = new Item(valor);
    if (primeiro == null) {
      primeiro = novo;
      ultimo = novo;
    }
    else {
      ultimo.SetProx(novo);    
      ultimo = novo;
    }
  }
  public void Imprimir() {
    Item aux = primeiro;
    while (aux != null) {
      Console.WriteLine(aux);
      aux = aux.GetProx();
    }
  }
  /*public int Quantidade() {  // len(lista)
    
  }
  public int Indice(string valor) {  // não existir -1, inicia em 0
                                     // lista.index()
  }
  public void Remover(string valor) {
    
  }*/
}

class Item {
  private string valor;
  private Item prox;
  public Item(string valor) { this.valor = valor; }
  public void SetValor(string valor) { this.valor = valor; }
  public void SetProx(Item prox) { this.prox = prox; }
  public string GetValor() { return valor; }
  public Item GetProx() { return prox; }
  public override string ToString() { return valor; }
}