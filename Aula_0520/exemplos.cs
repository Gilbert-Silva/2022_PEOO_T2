using System;
class Program {
  public static void Main() {
    string linha = Console.ReadLine();
    string[] valores = linha.Split();
    //string[] valores = Console.ReadLine().Split();
    double A = double.Parse(valores[0]);
    double B = double.Parse(valores[1]);
    double C = double.Parse(valores[2]);
    
    Console.WriteLine(A);
    Console.WriteLine(B);
    Console.WriteLine(C);
    
    int x = 1;
    double y = 2.5;
    string s = "Texto";
    char c = '4';
    bool b = true; // false

    Console.WriteLine(x);
    Console.WriteLine(y);
    Console.WriteLine(s);
    Console.WriteLine(c);
    Console.WriteLine(b);

    string[] v = { "abc", "def" };
    Console.WriteLine(v);
    foreach(string w in v)
      Console.WriteLine(w);

    string t = Console.ReadLine();
    int n = int.Parse(Console.ReadLine());
    double m = double.Parse(Console.ReadLine());

    Console.WriteLine(t);
    Console.WriteLine(n);
    Console.WriteLine($"{m:0.000}");
    Console.WriteLine($"{m:f3}");

    Console.WriteLine("Digite seu nome");
    string[] nome = Console.ReadLine().Split();
    Console.WriteLine(nome.Length);    
    Console.WriteLine(nome[0]);    
    Console.WriteLine(nome[1]);    
    Console.WriteLine(nome[2]);    
    
    foreach(string w in nome)
      Console.WriteLine(w);    
  }
}


