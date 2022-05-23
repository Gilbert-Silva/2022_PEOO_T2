using System;

class Program {
  public static void Main(string[] args) {
    if (args.Length == 2) {
      int a = int.Parse(args[0]);
      int b = int.Parse(args[1]);
      Console.WriteLine(a + b);
    }
    else
      Console.WriteLine("Informe dois valores após o nome do programa");
  }
}