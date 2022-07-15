using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite dois valores");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int menor, maior;
    if (a < b) {
      menor = a;
      maior = b;
    }
    else {
      menor = b;
      maior = a;
    }
    int x = menor;
    while (x <= maior) {
      Console.WriteLine(x);
      x++;
    }    
  }
}