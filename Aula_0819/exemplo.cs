using System;

class Program {
  public static void Main() {
    Console.WriteLine("Informe o número de elementos");
    int n = int.Parse(Console.ReadLine());
    int[] x = new int[n];
    for(int i = 0; i < n; i++) 
      x[i] = int.Parse(Console.ReadLine());
    foreach(int i in x)
      Console.WriteLine(i);
    for(int i = n-1; i >= 0; i--) 
      Console.WriteLine(x[i]);
  }
}