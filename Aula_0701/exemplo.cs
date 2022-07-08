using System;

class Program {
  public static void Main() {
    int x = 1;  // 0000 0000 0000 0001
    Console.WriteLine(x);
    x = x * 2;  // 0000 0000 0000 0010  
    Console.WriteLine(x);
    x = x * 2;  // 0000 0000 0000 0100
    Console.WriteLine(x);
    x = x * 2;  // 0000 0000 0000 1000
    Console.WriteLine(x);
    x = x * 2;  // 0000 0000 0001 0000
    Console.WriteLine(x);
    x = x * 2;  // 0000 0000 0010 0000
    Console.WriteLine(x);
    x = x * 2;  // 0000 0000 0100 0000
    Console.WriteLine(x);
    x = x * 2;  // 0000 0000 1000 0000
    Console.WriteLine(x);
    x = x * 2;  // 0000 0001 0000 0000
    Console.WriteLine(x);
    x = x * 2;  // 0000 0010 0000 0000
    Console.WriteLine(x);
    x = x * 2;  // 0000 0100 0000 0000 - 1K
    Console.WriteLine(x);
    x = x * 2;  // 0000 1000 0000 0000 
    Console.WriteLine(x);
    x = x * 2;  // 0001 0000 0000 0000 
    Console.WriteLine(x);
    x = x * 2;  // 0010 0000 0000 0000 
    Console.WriteLine(x);
    x = x * 2;  // 0100 0000 0000 0000 
    Console.WriteLine(x);
    x = x * 2;  // 0000 0000 0000 0000 1000 0000 0000 0000 - 32k
    Console.WriteLine(x);

    x = x * 2;  // 0000 0000 0000 0001 0000 0000 0000 0000
    Console.WriteLine(x);
    x = x * 2;  // 0000 0000 0000 0010 0000 0000 0000 0000
    Console.WriteLine(x);
    x = x * 2;  // 0000 0000 0000 0100 0000 0000 0000 0000
    Console.WriteLine(x);
    x = x * 2;  // 0000 0000 0000 1000 0000 0000 0000 0000
    Console.WriteLine(x);
    x = x * 2;  // 0000 0000 0001 0000 0000 0000 0000 0000 - 2^20 - 1M
    Console.WriteLine(x);
    x = x * 2;  // 0000 0000 0010 0000
    Console.WriteLine(x);
    x = x * 2;  // 0000 0000 0100 0000
    Console.WriteLine(x);
    x = x * 2;  // 0000 0000 1000 0000
    Console.WriteLine(x);
    x = x * 2;  // 0000 0001 0000 0000
    Console.WriteLine(x);
    x = x * 2;  // 0000 0010 0000 0000
    Console.WriteLine(x);
    x = x * 2;  // 0000 0100 0000 0000 - 1K
    Console.WriteLine(x);
    x = x * 2;  // 0000 1000 0000 0000 
    Console.WriteLine(x);
    x = x * 2;  // 0001 0000 0000 0000 
    Console.WriteLine(x);
    x = x * 2;  // 0010 0000 0000 0000 
    Console.WriteLine(x);
    x = x * 2;  // 0100 0000 0000 0000 0000 0000 0000 0000 - 1 GB
    Console.WriteLine(x); 
    x = x * 2;  // 1000 0000 0000 0000 0000 0000 0000 0000
    Console.WriteLine(x);
    x = 2147483647; // 0111 1111 1111 1111 1111 1111 1111 1111
    Console.WriteLine(x);
    x++;
    Console.WriteLine(x);
  }
}