using System;

class Program{
  public static void Main(){
  Disciplina x = new Disciplina();
  x.nome = "ingles";
  x.nota1 = 20;
  x.nota2 = 50;
  x.nota3 = 60;
  x.nota4 = 70;
  Console.WriteLine(x.MediaParcial());
  x.notaFinal = 60;
  Console.WriteLine(x.MediaFinal()); 
  }
}

class Disciplina{
  public string nome;
  public double nota1, nota2, nota3, nota4, notaFinal;
  public double MediaParcial(){
    double media = (2*nota1+2*nota2+3*nota3+3*nota4)/10;
    return media;
  }
  public double MediaFinal(){
    double mediaFinal = (notaFinal+media)/2;
    return mediaFinal;
  }
}