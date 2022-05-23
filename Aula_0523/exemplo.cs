using System;

class Program {
  public static void Main() {
    Console.WriteLine("Informe o número do mês (1-12)");
    string m = Console.ReadLine();

    if (m == "1") Console.WriteLine("Janeiro");
    if (m == "2") Console.WriteLine("Fevereiro");
    // .... Testar os outros meses
    if (m == "12") Console.WriteLine("Dezembro");

    switch(m) {
      case "1" : Console.WriteLine("Janeiro"); break;
      case "2" : Console.WriteLine("Fevereiro"); break;
      // .... Testar os outros meses
      case "12" : Console.WriteLine("Dezembro"); break;
    }
  }
}