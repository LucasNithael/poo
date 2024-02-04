using System;

class Program{
  public static void Main(){
  Disciplina x = new Disciplina();
  x.SetNome("inglês");
  x.SetNota1(60);
  x.SetNota2(60);
  x.SetNota3(60);
  x.SetNota4(60);
  Console.WriteLine("Media " + x.MediaParcial());
  x.SetNotaFinal(60);
  Console.WriteLine("Media Final " + x.MediaFinal()); 
  }
}

class Disciplina{
  private string nome;
  private double nota1, nota2, nota3, nota4, notaFinal;
  public void SetNome(string nome){
    if(nome != " ") this.nome = nome;
  }
  public void SetNota1(double nota1){
    if(nota1>0) this.nota1=2*nota1;
  }
  public void SetNota2(double nota2){
    if(nota2>0) this.nota2=2*nota2;
  }
  public void SetNota3(double nota3){
    if(nota3>0) this.nota3=3*nota3;
  }
  public void SetNota4(double nota4){
    if(nota4>0) this.nota4=3*nota4;
  }
  public void SetNotaFinal(double notaFinal){
    if(notaFinal>0) this.notaFinal = notaFinal;
  }
  public string GetNome(){
    return nome;
  }
  public double GetNota1(){
    return nota1;
  }
  public double GetNota2(){
    return nota2;
  }
  public double GetNota3(){
    return nota3;
  }
  public double GetNota4(){
    return nota4;
  }
  public double GetNotaFinal(){
    return notaFinal;
  }
  
  
  public double MediaParcial(){
    this.media = (nota1+nota2+nota3+nota4)/10;
    return media;
  }
  public double MediaFinal(){
    double mediaFinal = (notaFinal+MediaParcial())/2;
    return mediaFinal;
  }
}

