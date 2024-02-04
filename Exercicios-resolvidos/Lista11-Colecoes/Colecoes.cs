using System;
using System.Collections;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    string[] v = new string[5];
    v[0] = "Coleções";
    v[1] = "em";
    v[2] = "C#";
    v[3] = "11";
    v[4] = "2020";
    foreach(string s in v)
      Console.WriteLine(s);

    // ArrayList: pode inserir quaisquer tipo de elemento
    Console.WriteLine("\nARRAY LISTA:");
    ArrayList a = new ArrayList();
    a.Add("Coleções");
    a.Add("em");
    a.Add("C#");
    a.Add(11);
    a.Add(2020);
    foreach(object s in a)
      Console.WriteLine(s);

    // List
    Console.WriteLine("\nLISTA:");
    List<string> a2 = new List<string>();
    a2.Add("Coleções");
    a2.Add("em");
    a2.Add("C#");
    a2.Add("11");
    a2.Add("2020");
    foreach(string s in a2)
      Console.WriteLine(s);

    /* QUEUE: fila, primeiro elemnto que entra é  o último que sai;
    - No fim da desmonstração há duas formas de imprimir os elementos inseridos; 
    - a class Queue implementa a interface IEnumerable, então posso percorrer os elementos usando o foreach 

    */
    Console.WriteLine("\nFILA:");
    Queue<string> f = new Queue<string>();
    f.Enqueue("Coleções");
    f.Enqueue("em");
    f.Enqueue("C#");
    f.Enqueue("11");
    f.Enqueue("2020");
     foreach(Object i in f)
      Console.WriteLine(i);
    //while(f.Count > 0)
      //Console.WriteLine(f.Dequeue());


    
    /* PILHA: último que entra é o primeiro que stati;
    - No fim da desmonstração há duas formas de imprimir os elementos inseridos; 
    - a class Queue implementa a interface IEnumerable, então posso percorrer os elementos usando o foreach
    */
    Con
    Console.WriteLine("\nPILHA:");
    Stack<string> p = new Stack<string>();
    p.Push("Coleções");
    p.Push("em");
    p.Push("C#");
    p.Push("11");
    p.Push("2020");
    foreach(Object i in p)
      Console.WriteLine(i);
    //while(p.Count > 0)
      //Console.WriteLine(p.Pop());

  }
}