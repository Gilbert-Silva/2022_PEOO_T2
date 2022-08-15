using System;
using System.Collections;
using System.Collections.Generic;

class Program {
  public static void Main() {

    object a = "Teste";
    object b = 10;
    Console.WriteLine(a);
    Console.WriteLine(b);
    
    ArrayList lista = new ArrayList();   // type-unsafe
    lista.Add("Listas");
    lista.Add("em");
    lista.Add("C#");
    lista.Add(2022);
    //Console.WriteLine(lista[0] + lista[1]);
    foreach(object x in lista)
      Console.WriteLine(x);

    List<int> lista2 = new List<int>();  // type-safe
    lista2.Add(10);
    lista2.Add(20);
    lista2.Add(30);
    lista2.Add(40);
    Console.WriteLine(lista2[0] + lista2[1]);
    foreach(int y in lista2)
      Console.WriteLine(y);

    Console.WriteLine("Pilha");  // LIFO
    Stack p = new Stack();
    p.Push(10);
    p.Push(20);
    p.Push(30);
    p.Push(40);
    while (p.Count > 0)
      Console.WriteLine(p.Pop());

    Console.WriteLine("Fila");  // FIFO
    Queue f = new Queue();
    f.Enqueue(10);
    f.Enqueue(20);
    f.Enqueue(30);
    f.Enqueue(40);
    while (f.Count > 0)
      Console.WriteLine(f.Dequeue());
  }
}
