using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite um valor");
    int m = int.Parse(Console.ReadLine());
    string mes = "";
    string tri = "";
    switch (m) {
      case 1 : mes = "Jan"; tri = "1º"; break;
      case 2 : mes = "Fev"; tri = "1º"; break;
      case 3 : mes = "Mar"; tri = "1º"; break;
      case 4 : mes = "Abr"; tri = "2º"; break;
      case 5 : mes = "Mai"; tri = "2º"; break;
      case 6 : mes = "Jun"; tri = "2º"; break;
      case 7 : mes = "Jul"; tri = "3º"; break;
      case 8 : mes = "Ago"; tri = "3º"; break;
      case 9 : mes = "Set"; tri = "3º"; break;
      case 10 : mes = "Out"; tri = "4º"; break;
      case 11 : mes = "Nov"; tri = "4º"; break;
      case 12 : mes = "Dez"; tri = "4º"; break;
      default : mes = "Número inválido"; tri = "Inválido"; break;
    }
    Console.WriteLine($"O mês de {mes} é no {tri} trimestre");
  }
}