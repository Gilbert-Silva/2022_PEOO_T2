using System;

class Program {
  public static void Main() {
    // Console.WriteLine("Digite uma data \"dd/mm/yyyy\"");
    int x = 10, y;
    Console.WriteLine(x);
    Metodo1(x);
    Console.WriteLine(x);
    Metodo2(ref x);
    Console.WriteLine(x);
    Metodo3(out y);
    Console.WriteLine(y);
    Console.WriteLine("Digite um valor inteiro");
    int z = int.Parse(Console.ReadLine());
    int v, w;
    AntecessorSucessor(z, out v, out w);
    Console.WriteLine(v);
    Console.WriteLine(w);
    AntecessorSucessor(10, out v, out w);
    Console.WriteLine(v);
    Console.WriteLine(w);
    // AntecessorSucessor(10, 11, 12);
  }
  public static void AntecessorSucessor (int x, out int 
    antecessor, out int sucessor) {
      antecessor = x - 1;
      sucessor = x + 1;
  }
  public static void Metodo1(int a)     { a = 20; }
  public static void Metodo2(ref int a) { a = 20; }
  public static void Metodo3(out int a) { a = 30; } 
}