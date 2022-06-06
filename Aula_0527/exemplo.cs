using System;

class Program {
  public static void Main() {
    int x = 4;
    for (int i = 1; i < 30; i++) {
      x = x << 1;
      Console.WriteLine(x);
    }
  }
}