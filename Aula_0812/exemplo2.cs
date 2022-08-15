using System;

class Program {
  public static void Main() {
    double x = 1.5e6;  // 1.5 x 1000000
    Console.WriteLine(x);
    x = 1e-4;
    Console.WriteLine(x);
    string s = "Teste";
    Console.WriteLine(s.GetType());
    Console.WriteLine(s[0].GetType());
    char c = '1';
    Console.WriteLine(c.GetType());
    Console.WriteLine(c + c);

    Console.WriteLine(s + x);
    Console.WriteLine(c + s);
    Console.WriteLine(8/2/2);

    x = double.Parse(Console.ReadLine());
    Console.WriteLine(x);
    
    
  }
}
