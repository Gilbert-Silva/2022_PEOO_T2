using System;

public class Program { 
  public static void Main(string[] args) { 
    int a = int.Parse(Console.ReadLine()); 
    int b = int.Parse(Console.ReadLine()); 
    int c = int.Parse(Console.ReadLine()); 
    int d = int.Parse(Console.ReadLine()); 

    // Todos diferentes
    // (a != b && a != c && a != d && b != c && b != d && c != d)  

    // Algum número repetido
    if (a == b || a == c || a == d || b == c || b == d || c == d) {
      Console.WriteLine("Algum número está repetido");
    }
    else {
      int maior = a;
      if (b > maior) maior = b;
      if (c > maior) maior = c;
      if (d > maior) maior = d;
      int soma = a + b + c + d - maior;
      Console.WriteLine(soma);

      //if (a > b && a > c && a > d) soma = b + c + d;
      //if (b > a && b > c && b > d) soma = a + c + d;
    }
  }
}