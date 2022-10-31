using System;

class Program {
  public static void Main() {
    int[] x = new int[10];
    for (int i = 0; i < 10; i++) {
      x[i] = int.Parse(Console.ReadLine());
      if (x[i] <= 0) x[i] = 1;
    }
    for (int i = 0; i < 10; i++) 
      Console.WriteLine($"X[{i}] = {x[i]}");
      //Console.WriteLine("X[" + i + "] = " + x[i]");
  }
}