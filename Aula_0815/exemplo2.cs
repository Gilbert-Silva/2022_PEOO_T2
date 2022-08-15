using System;

class Program {
  public static void Main() {
    Console.WriteLine("Informe uma data no formato dd/mm/aaaa");
    string data = Console.ReadLine();
    Console.WriteLine(data);
    string[] v = data.Split('/');
    Console.WriteLine(v[0]);
    Console.WriteLine(v[1]);
    Console.WriteLine(v[2]);
    int ano = int.Parse(v[2]);
    Console.WriteLine(ano);
    Console.WriteLine($"{v[0]}/{v[1]}/{ano}");
    bool teste = 
      (ano % 4 == 0 && ano % 100 != 0) || 
      (ano % 400 == 0);
    if (teste) {
      Console.WriteLine("O ano é bissexto");
    }
    else {
      Console.WriteLine("O ano não é bissexto");
    }
  }
}