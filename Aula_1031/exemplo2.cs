using System;

class Program {
  public static void Main() {
    int[] vetor = { 10, 4, 6, 3, 8, 12, 15, 20 };
    Console.WriteLine(Array.IndexOf(vetor, 8));
    Console.WriteLine(Array.IndexOf(vetor, 2));
    foreach (int i in vetor)       // i é o elemento
      Console.WriteLine(i);
    for (int i = 7; i >= 0; i--)   // i é a posição
      Console.WriteLine(i + " " + vetor[i]);
    for (int i = 0; i < vetor.Length; i += 2)   // i é a posição
      Console.WriteLine(i + " " + vetor[i]);
    
  }
}
