using System;

class Program {
  public static void Main() {
    int c = 0;
    for (int i = 1; i <= 6; i++) {
      int x = int.Parse(Console.ReadLine());
      if (x > 0) c++;  // c += x;
    }
    Console.WriteLine($"{c} valores positivos");
  }
}