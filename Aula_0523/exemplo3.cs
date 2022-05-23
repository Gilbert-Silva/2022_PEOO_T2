using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite dois valores inteiros");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    if (a == b) Console.WriteLine("Os números são iguais");
    if (a > b) Console.WriteLine($"Maior = {a}");
    if (b > a) Console.WriteLine($"Maior = {b}");
  }
}

