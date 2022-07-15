using System;

class Program {
  public static void Main() {
    int x = 1;
    while (x <= 99) {
      if (x % 2 == 1) Console.WriteLine(x);
      x++;
    }
  }
  public static void Main2() {
    int x = 1;
    while (x <= 99) {
      Console.WriteLine(x);
      x = x + 2;
    }
  }
}