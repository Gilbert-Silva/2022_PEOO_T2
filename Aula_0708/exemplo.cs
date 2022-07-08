using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase");
    string s = Console.ReadLine();
    string[] v = s.Split();
    int n = 0;
    while (n < v.Length) {
      int i = n;
      while(i < v.Length) {
        Console.Write(v[i] + " ");
        i++;
      }
      Console.WriteLine();
      n++;
    }
  }


  


  
  public static void Questao07() {
    Console.WriteLine("Digite uma frase");
    string s = Console.ReadLine();
    Console.WriteLine(s);
    int p = s.IndexOf(' ');
    while (p != -1) {
      s = s.Substring(p + 1);
      Console.WriteLine(s);
      p = s.IndexOf(' ');
    }
  }

  public static void Questao03() {
    int x = 1; 
    int y = 1;
    while (x <= 10) {
      Console.WriteLine(x * y);
      y = -y;
      x++;
    }
  }
}