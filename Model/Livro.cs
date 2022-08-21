using System;

class Livro{
  public int Id{get;set;}
  public string Titulo{get; set;}
  private int AnoLancamento;
  public int IdAutor{get;set;}
  public int IdGenero{get;set;}
  public int IdLeitor{get;set;}
  public void SetAnoLancamento(int ano){
    if(ano>0 && ano<(DateTime.Today.Year+1))
      AnoLancamento = ano;
  }
  public int GetAnoLancamento(){
    return AnoLancamento;
  }
  public override string ToString(){
    return $"{Id} - {Titulo} - {AnoLancamento}";
  }
}