using System;
using System.Collections.Generic;

/*
Dúvidas:
- Como inserir os itens na lista
- O porquê da class Orçamento não ter construtor e ter atributos privados
- Tem alguma forma de acessar atributos de uma class abstrata sem ele ser protegido e sem método de acesso
*/

class Program{
  public static void Main(){
    Orcamento o = new Orcamento();
    Item a = new Servico("ServicoA", 10);
    Item b = new Material("MaterialB", 20);
    
  }
}

class Orcamento{
  private string cliente;
  private DateTime data;
  private List<Item> itens = new List<Item>();
  public decimal Total(){
    decimal total = 0;
    foreach(Item i in itens)
      total += i.GetPreco();
    return total;
  }
}

abstract class Item{
  private string descricao;
  private int qtd;
  public Item(string d, int q){
    this.descricao = d;
    this.qtd = q;
  }
  public abstract decimal GetPreco();
  public override string ToString(){
    return $"{descricao} - {qtd}";
  }
}

class Servico : Item{
  private int tempo;
  public Servico(string d, int t):base(d, 0){this.tempo=t;}
  public override decimal GetPreco(){
    decimal preco = (decimal)tempo*(decimal)6;
    return preco;
  }
  public override string ToString(){
    return $"{tempo}";
  }
}

class Material : Item{
  private decimal precoCompra;
  public Material(string d, decimal p):base(d, 0){
    this.precoCompra = p;
  }
  public override decimal GetPreco(){
    return precoCompra;
  }
  public override string ToString(){
    return $"{precoCompra}";
  }
}