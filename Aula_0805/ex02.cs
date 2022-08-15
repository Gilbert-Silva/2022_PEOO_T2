using System;

class Program {
  public static void Main() {
    Console.WriteLine("Informe o número para contar os múltiplos:");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine($"O número de múltiplos é: {ContarMultiplos2(x)}");
  }
  public static int ContarMultiplos(int x) {
    return 1000/x;
  }
  public static int ContarMultiplos2(int x) {
    int n = 1;
    int k = 0;
    while (n <= 1000) {
      if (n % x == 0) k++;
      n++;
    }
    return k;
  }
}