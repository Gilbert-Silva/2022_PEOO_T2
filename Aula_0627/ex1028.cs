using System;

class Program {
  public static void Main() {
    int n = int.Parse(Console.ReadLine());
    for (int i = 1; i <= n; i++) {
      string[] v = Console.ReadLine().Split();
      int x = int.Parse(v[0]);
      int y = int.Parse(v[1]);
      Console.WriteLine(MDC(x, y));
    }
    //Console.WriteLine(MDC(8, 12));
    //Console.WriteLine(MDC(9, 27));
    //Console.WriteLine(MDC(259, 111));
    //Console.WriteLine(MDC3(259, 111));
  }

  public static int MDC(int x, int y) {
    int d = Math.Min(x, y);
    //if (x < y) d = x; else d = y;
    while ( (x % d == 0 && y % d == 0) == false ) 
    {  
      //Console.WriteLine($"{x}%{d}={x%d} {y}%{d}={y%d}");
      d--;
    }
    return d;
  }

  public static int MDC2(int x, int y) {
    while (x % y != 0) {
      int xorigem = x;
      x = y;
      y = xorigem % y;
    }
    return y;
  }
  public static int MDC3(int x, int y) {
    if (x % y == 0) return y;
    return MDC3(y, x%y);
  }

}

