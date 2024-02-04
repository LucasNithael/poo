using System;
using System.Globalization;
using System.Threading;


enum SituacaoEstagio{Cadastrado, Iniciado, Cancelado, Finalizado};

class Program{
  public static void Main(){
    CultureInfo ci = new CultureInfo("pt-BR");
    Thread.CurrentThread.CurrentCulture = ci;
    Estagio x = new Estagio("Lucas", "Americanas");
    x.Iniciar(Convert.ToDateTime("27/11/2007"));
    x.Finalizar(Convert.ToDateTime("30/12/2007"));
    Console.WriteLine(x);
    Console.WriteLine(x.Situacao());
    Console.WriteLine(x.TempoEstagio().Days);
  }
}

class Estagio{
  private string estagiario;
  private string empresa;
  private DateTime dataInicio;
  private DateTime dataCancelamento;
  private DateTime dataFim;
  private SituacaoEstagio situacao;
  public Estagio(string est, string emp){
    this.estagiario = est;
    this.empresa = emp;
    this.situacao = SituacaoEstagio.Cadastrado;
  }
  public bool Iniciar(DateTime data){
    if(Situacao()==SituacaoEstagio.Cadastrado){
      situacao = SituacaoEstagio.Iniciado;
      dataInicio = data;
      return true;
    }
    else return false;
  }
  
   public bool Cancelar(DateTime data){
    if(Situacao()==SituacaoEstagio.Iniciado){
      dataCancelamento = data;
      situacao = SituacaoEstagio.Cancelado;
      return true;
    }
    else return false;
  }
 
  public bool Finalizar(DateTime data){
    if(Situacao() ==  SituacaoEstagio.Iniciado){
      dataFim = data;
      situacao = SituacaoEstagio.Finalizado;
      return true;
    }
    else return false;
  }
  public TimeSpan TempoEstagio(){
     if(Situacao() ==  SituacaoEstagio.Iniciado){
        return DateTime.Today - dataInicio;
     }
    if(Situacao() ==  SituacaoEstagio.Cancelado){
        return dataCancelamento - dataInicio;
     }
    if(Situacao() ==  SituacaoEstagio.Finalizado){
        return dataFim - dataInicio;
     }
    else return DateTime.Today- DateTime.Today;
  
  }
  public SituacaoEstagio Situacao(){
    return situacao;
  }
  public override string ToString(){
    return $"Empresa: {empresa} - Estagiário: {estagiario}";
  }
}
