 using System;
using System.Collections;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    /*
    h[chave] = valor;

    -A ordem  é feita de forma aleatória
    -A inserção dos itens pode ser feita usando os operadores de indexação ou usando os o método Add. Com os operadores de indexação podemos modificar os valores das chaves já existente

    -Duvidas:  Hashtable vs SortedList ** 
    */
    Hashtable h = new Hashtable();
    h["Brasil"] = 5;
    //d["Brasil"] = 1000;   //O valor da chave Brasil será mudado
    h["Itália"] = 4;
    h["Alemanha"] = 4;
    h["Argentina"] = 2;
    h.Add("Uruguai", 2);
    h.Add("França", 2);
    h.Add("Inglaterra", 1);
    h.Add("Espanha", 1);
    foreach (DictionaryEntry x in h)
      Console.WriteLine(
        $"{x.Key} = {x.Value} Título(s)");

Console.WriteLine();
    /*
    d[chave] = valor;

    -há a versão genérica e não genérica, a seguinte é genérica;
    - As chaves dos dicionarios ordenados precisam implementar IComparable para que seja possível realizar a ordenação

-A inserção dos itens pode ser feita usando os operadores de indexação ou usando os o método Add. Com os operadores de indexação podemos modificar os valores das chaves já existente

    -Duvidas: 
      *E se os as cahves não implementar IComparable. 
      *Versão genérica vs Não genérica
    */
    SortedList<string, int> d = new SortedList<string, int>();
    d["Brasil"] = 5;
    //d["Brasil"] = 1000;   //O  valor da chave Brasil será mudado
    d["Itália"] = 4; 
    d["Alemanha"] = 4;
    d["Argentina"] = 2;
    d.Add("Uruguai", 2);
    d.Add("França", 2);
    d.Add("Inglaterra", 1);
    d.Add("Espanha", 1);
    foreach (KeyValuePair<string, int> x in d)
      Console.WriteLine(
        $"{x.Key} = {x.Value} Título(s)");
        
  }
}