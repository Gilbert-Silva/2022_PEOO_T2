using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite um valor inteiro");
    int x;
    while (int.TryParse(Console.ReadLine(), out x) == false)
    {
      Console.WriteLine("Digite outro valor");       
    }
    x++;
    Console.WriteLine(x);
  }
}

bool TryParse(string s, out int x) {
  
}
