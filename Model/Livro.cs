using System;

class Livro{
  public int Id{get;set;}
  public string Titulo{get; set;}
  private int anoLancamento;
  public int IdAutor{get;set;}
  public int IdGenero{get;set;}
  public int IdLeitor{get;set;}
  public void SetAnoLancamento(int ano){
    if(ano>0 && ano<(DateTime.Today.Year+1))
      anoLancamento = ano;
  }
  public int GetAnoLancamento(){
    return anoLancamento;
  }
  public override string ToString(){
    Genero genero = NGenero.Pesquisar(IdGenero);
    return $"{Id} - {Titulo} - {anoLancamento} - Genero: {genero.Descricao}";
  }
}