using System;

class Program{
  public static void Main(){
    Colecao x = new Colecao(2);
    Item item1 = new Item("Mouse", 2);
    Item item2 = new Item("Boné", 5);
    x.Inserir(item1);
    x.Inserir(item2);
    foreach(object i in x.Listar())
      Console.WriteLine(i);
  }
}

class Item{
  private string nome;
  private int id;
  public Item(string nome, int id){
    this.nome = nome;
    this.id = id;
  }
  public override string ToString(){
    return $"{id} {nome}";
  }
}

class Colecao{
  private object[] itens;
  private int max;
  private int k;
  public Colecao(int max){
    this.max = max;
    itens = new object[max];
  }
  public void Inserir(Item x){
    if(k<max){
      itens[k] = x;
      k++;
    }
  }
  public object[] Listar() {
    object[] r = new object[k];
    Array.Copy(itens, r, k);
    return r;
  }
}