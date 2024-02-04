using System;
using System.Globalization;
using System.Threading;

class Program{
  public static void Main(){
    CultureInfo ci = new CultureInfo("pt-BR");
    Thread.CurrentThread.CurrentCulture = ci;
    Premio x = new Premio("Lucas", DateTime.Parse("20/06/2020"));
  

    ValeCompras a = new ValeCompras(DateTime.Parse("30/08/2020"), 100.00);
    Produto b = new Produto("4kg de Carne", 100.00);

    x.SetPremio(a);
    Console.WriteLine(x);
    
  }
}

class Premio{
  private string cliente;
  private DateTime data;
  private object premio;
  public Premio(string cliente, DateTime data){
    this.cliente = cliente;
    this.data = data;  
  }
  public void SetPremio(object p){
    this.premio = p;
  }
  public object GetPremio(){
    return premio;
  }
  public override string ToString(){
    return $"Cliente: {cliente}, {data:dd/MM/yyyy}\nPremiação: {premio}";
  }
}

class ValeCompras{
  private DateTime dataValidade;
  private double valor;
  public ValeCompras(DateTime d, double v){
    this.dataValidade = d;
    this.valor = v;
  }
  public override string ToString(){
    return $"Vale compras\nValidade {dataValidade:dd/MM/yyyy} - Valor: R$ {valor:0.00}";
  }
}


class Produto{
  private string descricao;
  private double valor;
  public Produto(string descricao, double valor){
    this.descricao = descricao;
    this.valor = valor;
  }
  public override string ToString(){
    return $"Produto\n{descricao} - Valor: R${valor:0.00}";
  }
}