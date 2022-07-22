using System;

class Program {
  public static void Main() {
    int a = 10;
    int b = 20;
    int x = 30;
    Metodo1(a, b);    
    Metodo2(a, b);    
    Console.WriteLine(a);
    Console.WriteLine(b);
    x = Metodo3(x);
    Console.WriteLine(x);
  }
  public static int Metodo3(int x) {
    x = 2 * x;
    Console.WriteLine(x);
    return x;
  }
  public static void Metodo1(int b, int a) {
    Console.WriteLine(a);
    Console.WriteLine(b);
    //Console.WriteLine(x);
  }
  public static void Metodo2(int a, int b) {
    a = 30;
    b = 40;
  }
}