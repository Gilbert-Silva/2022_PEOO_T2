using System;

class Program {
  public static void Main() {
    int[] vetor = new int[4] { 10, 4, 6, 3 };
    Console.WriteLine(vetor[0]);
    Console.WriteLine(vetor[1]);
    Console.WriteLine(vetor[2]);
    Console.WriteLine(vetor[3]);
    int[] w = { 7, 3, 15, 18 };
    int[] z = w;
    z[0] = 10;
    Console.WriteLine(w[0]);
    Console.WriteLine(w[1]);
    Console.WriteLine(w[2]);
    Console.WriteLine(w[3]);
    Console.WriteLine(w.Length);
    Console.WriteLine(w.Rank);
    string s = "Informatica para Internet"; // Imutável
    s = "Teste 123 456";
    Console.WriteLine(s[0]);
    Console.WriteLine(s[1]);
    Console.WriteLine(s[2]);
    Console.WriteLine(s[3]);
    Console.WriteLine(s[4]);
    string[] vs = s.Split();
    Console.WriteLine(vs[0]);
    Console.WriteLine(vs[1][2]);
    Console.WriteLine(vs[2]);
    
    
  }
}