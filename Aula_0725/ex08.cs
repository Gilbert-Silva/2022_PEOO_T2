using System;

class Program {
  public static void Main() {
    double d = 4.5;
    int i = (int) d;
    Console.WriteLine(d);
    Console.WriteLine(i);
    if (d == i) Console.WriteLine(i);
    else Console.WriteLine(i+1);
    Console.WriteLine(MenorInteiro(4.5));
    Console.WriteLine("Ceiling = " + Math.Ceiling(4.5));
    Console.WriteLine("Floor = "   + Math.Floor(4.5));
    Console.WriteLine("Ceiling = " + Math.Ceiling(-4.5));
    Console.WriteLine("Floor = "   + Math.Floor(-4.5));
  }
  public static int MenorInteiro(double x) {
    int i = (int) x;
    if (x == i) return i;
    else return i+1;    
  }
}

    