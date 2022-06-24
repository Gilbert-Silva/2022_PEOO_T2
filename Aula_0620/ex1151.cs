using System;
class Program {
  public static int Fibo(int i) {
    if (i == 1) return 0;
    if (i == 2) return 1;
    return Fibo(i - 2) + Fibo(i - 1);
  }
  
  public static void Main() {
    int n = int.Parse(Console.ReadLine());
    Console.Write(Fibo(1));
    for(int k = 2; k <= n; k++) {
      Console.Write(" " + Fibo(k));
    }
    Console.WriteLine();
  }

  
  public static void Main2() {
    int n = int.Parse(Console.ReadLine());
    if (n == 1) Console.Write("0");
    if (n >= 2) Console.Write("0 1");
    int a = 0;
    int b = 1;
    for(int k = 3; k <= n; k++) {
      int c = a + b;
      Console.Write(" " + c);
      a = b;
      b = c;
    }
    Console.WriteLine();
  }
}