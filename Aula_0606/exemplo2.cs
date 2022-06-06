using System;

class Program {
  public static void Main() {
    Console.WriteLine("while");
    int i = 1;
    while (i <= 10) {
      Console.WriteLine(i);
      i++; 
    }
    Console.WriteLine("for");
    for(i = 1; i <= 10; i++) {
      Console.WriteLine(i);
    }
    Console.WriteLine("do-while");
    i = 1;
    do {
      Console.WriteLine(i);
      i++; 
    } while (i <= 10);
    Console.WriteLine("foreach");
    int[] v = { 5, 9, 2, 1, 7 };
    foreach(int x in v) {
      Console.WriteLine(x);
      Console.WriteLine("Maria Cândida");
    }
    string s = "Informática para Internet";
    foreach(char c in s)
      Console.WriteLine(c);
  }
}