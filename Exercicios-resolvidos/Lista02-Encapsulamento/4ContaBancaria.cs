using System;

class Program {
  public static void Main() {
    ContaBancaria x = new ContaBancaria();
    x.SetTitular("Lucas Nithael");
    x.SetNumero("123-X");
    x.SetDepositar(400);
    Console.WriteLine("Conta de " + x.GetTitular());
    Console.WriteLine(x.GetNumero());
    Console.WriteLine("Saldo após o depósito");
    Console.WriteLine(x.GetSaldo());
    x.SetSacar(100);
    Console.WriteLine("Saldo após o saque");
    Console.WriteLine(x.GetSaldo());
    
    //ContaBancaria y = new ContaBancaria();
    //Console.WriteLine(y.titular);
    //Console.WriteLine(y.numero);
    //Console.WriteLine(y.saldo);
  }
}

class ContaBancaria {
  private string titular, numero;
  private double saldo=0;
  
  public void SetTitular(string titular){
    if(titular.IndexOf(' ') != -1) this.titular = titular;
  }
  public void SetNumero(string numero){
    if (numero.IndexOf('-') != -1) this.numero = numero;
    //else Console.WriteLine("Número é inválido");
  }
  public void SetDepositar(double valor) {
    // saldo += valor;
    if(valor>0) this.saldo += valor;
  }
  public void SetSacar(double valor) {
    // saldo -= valor;
    if(valor>0 && valor<=saldo) this.saldo -= valor;
  }
  public string GetTitular(){
    return titular;
  }
  public string GetNumero(){
    return numero;
  }
  public double GetSaldo(){
    return saldo;
  }
}