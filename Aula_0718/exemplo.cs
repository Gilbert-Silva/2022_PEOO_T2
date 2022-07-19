using System;

class Program {
  public static void Main() {
    //int n = int.Parse(Console.ReadLine());
    Mensagem();    
    Bemvindo("Joaquim");
    Bemvindo("Renan");
    double x = PI();
    Console.WriteLine(x);
    Console.WriteLine(PI());
    Console.WriteLine(ProximoNumero(18));
    int i = 18;
    Console.WriteLine(ProximoNumero(i));
    Console.WriteLine(i);
    Console.WriteLine(ProximoNumero2(ref i));
    Console.WriteLine(i);
    Console.WriteLine(ProximoNumeroPar(11));
    Console.WriteLine(ProximoNumeroPar(10));
    MostrarNumeros(1, 10);
    MostrarNumeros(21, 30);
    Console.WriteLine(Fatorial(1));
    Console.WriteLine(Fatorial(2));
    Console.WriteLine(Fatorial(4));
  }

  public static int Fatorial(int x) {
    if (x <= 1) return 1;
    return x * Fatorial(x - 1);
  }
  
  public static void MostrarNumeros(int x, int y) {
    int i = x;
    while (i <= y) {
      Console.WriteLine(i);
      i++;
    }
  }
  public static int ProximoNumeroPar(int x) {
    if (x % 2 == 0) x += 2;
    else x++;
    return x;
  }
  public static int ProximoNumero(int x) {
    x = x + 1;
    return x;
  }
  public static int ProximoNumero2(ref int x) {
    x = x + 1;
    return x;
  }
  public static void Mensagem() {
    Console.WriteLine("Olá");
  }
  public static void Bemvindo(string s) {
    Console.WriteLine("Bem-vindo, " + s);
  }
  public static double PI() {
    return 3.1415;
  }  
}