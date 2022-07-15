using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase");
    string s = Console.ReadLine() + " ";
    int k = 0;
    int c = 0;
    while (k < s.Length) {
      if (s[k] == ' ') {
        Console.Write(s[k-1]);
        int n = 0;
        while (n < c) {
          Console.Write(s[k-1]);
          n++;
        }        
        Console.Write(" ");
        c++;
      }
      k++;
    }
  }

  public static void Main2() {
    Console.WriteLine("Digite uma frase");
    string s = Console.ReadLine();
    string[] v = s.Split();
    int k = 0;
    while (k < v.Length) {
      string p = v[k];
      Console.Write(p[p.Length-1]);
      int n = 0;
      while (n < k) {
        Console.Write(p[p.Length-1]);
        n++;
      }
      Console.Write(" ");
      k++;
    }
    //foreach(string p in v) 
    //  Console.WriteLine(p[p.Length-1]);
  }
  
}
