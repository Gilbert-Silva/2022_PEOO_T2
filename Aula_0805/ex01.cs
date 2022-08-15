using System;

class Program {
  public static void Main() {
    Console.WriteLine("Informe sua massa em kg:");
    double m = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe sua altura em metros:");
    double a = double.Parse(Console.ReadLine());

    double imc = IMC(m, a);

    Console.WriteLine($"Seu IMC é {imc}"); 
  }
  public static double IMC(double massa, double altura) {
    return massa / (altura * altura);
  }
}