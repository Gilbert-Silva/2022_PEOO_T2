using System;

class Program {
  public static void Main() {
    double a = 5;
    double b = 6.5;
    double c = Program.Maior(a, b);
    Console.WriteLine(c);
    Console.WriteLine(Maior(8, 10));
    Console.WriteLine(Matematica.Maior(18, 10));
    Console.WriteLine(Matematica.Maior(a, b));
    Console.WriteLine(Math.Max(10, 20));
  }
  public static double Maior(double x, double y) {
    if (x > y) return x;
    else return y;
  }
}
class Matematica {
  public static double Maior(double x, double y) {
    if (x > y) return x;
    else return y;
  }
}
/*
class Math {
  public static double Max(double x, double y) {
    if (x > y) return x;
    else return y;
  }
}
*/