using System;

class Program {
  public static void Main() {
    Console.WriteLine("Comecei aqui");
    Console.WriteLine( Menor(10, 20) );
    double v = Menor(20, 30);
    Console.WriteLine( v );
    MostreMenor(50, 30);
    Console.WriteLine("Digite dois valores");
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine(Menor(a, b));
  }
  public static double Menor(double x, double y) {
    //Console.WriteLine("Cheguei aqui");
    //Console.WriteLine(x);
    //Console.WriteLine(y);
    // Solução 1
    if (x < y) return x;
    else return y;
    // Solução 2
    //return Math.Min(x, y);
    // Solução 3
    //return x < y ? x : y;
  }
  public static void MostreMenor(double x, double y) {
    Console.WriteLine("Cheguei nesse método");
    Console.WriteLine(x);
    Console.WriteLine(y);
    if (x < y) Console.WriteLine(x);
    else Console.WriteLine(y);
  }  
}