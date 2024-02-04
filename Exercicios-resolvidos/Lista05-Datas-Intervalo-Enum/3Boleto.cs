using System;


enum Pagamento {Emaberto, ParcialmentePago, Pago};

class Program{
 public static void Main(){
   Boleto b = new Boleto(500);
   Console.WriteLine(b);
   b.Pagar(100);
   Console.WriteLine(b);
   b.Pagar(500);
   Console.WriteLine(b);
 }
}


class Boleto{
 private double valorBoleto, valorPago;
 private Pagamento situacao;
 public Boleto(double valor){
  if(valor > 0){
   valorBoleto = valor;
   valorPago = 0;
   situacao = Pagamento.Emaberto;
  }
 }
 public void Pagar(double valorPago){
  if(valorPago > 0){
   this.valorPago = valorPago;
   if(valorPago==valorBoleto){
    situacao = Pagamento.Pago;
   }
   else situacao = Pagamento.ParcialmentePago;
  }
 }
 public Pagamento Situacao(){
  return situacao;
 }
 public override string ToString(){
  return $"Valor = {valorBoleto:c2}, Pago = {valorPago}, Situação = {situacao}";
 } 
}

