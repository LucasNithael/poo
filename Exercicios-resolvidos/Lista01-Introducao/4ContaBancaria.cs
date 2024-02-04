using System;

class Program {
  public static void Main() {
    ContaBancaria x = new ContaBancaria();
    x.titular = "Eduardo";
    x.numero = "123-X";
    x.Depositar(100);
    Console.WriteLine("Conta de " + x.titular);
    Console.WriteLine(x.numero);
    Console.WriteLine("Saldo após o depósito");
    Console.WriteLine(x.saldo);
    x.Sacar(300);
    Console.WriteLine("Saldo após o saque");
    Console.WriteLine(x.saldo);
    
    ContaBancaria y = new ContaBancaria();
    Console.WriteLine(y.titular);
    Console.WriteLine(y.numero);
    Console.WriteLine(y.saldo);
  }
}

class ContaBancaria {
  public string titular, numero;
  public double saldo;
  public void Depositar(double valor) {
    // saldo += valor;
    this.saldo += valor;
  }
  public void Sacar(double valor) {
    // saldo -= valor;
    this.saldo -= valor;
  }
}