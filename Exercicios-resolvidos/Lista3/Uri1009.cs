using System; 

class URI {

    static void Main(string[] args) { 
      string nome = Console.ReadLine();
      double salario = double.Parse(Console.ReadLine());
      double vendas = double.Parse(Console.ReadLine());
      double total = vendas*15/100+salario;
      Console.WriteLine($"TOTAL = R$ {total:0.00}");
    }

}