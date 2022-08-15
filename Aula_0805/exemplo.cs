using System;

class Program {
  public static void Main() {
    int x = 5;
    Console.WriteLine(x);
    Triangulo t1 = new Triangulo();
    Console.WriteLine($"Base = {t1.b}, Altura = {t1.h}");
    t1.b = -10;
    t1.h = 20;
    Console.WriteLine($"Base = {t1.b}, Altura = {t1.h}");
    Console.WriteLine($"Area = {t1.b * t1.h / 2}");
    Console.WriteLine($"Area = {t1.CalcArea()}");
    Triangulo t2 = new Triangulo();
    t2.b = 40;
    t2.h = 50;
    Console.WriteLine($"Base = {t2.b}, Altura = {t2.h}");
    Console.WriteLine($"Area = {t2.b * t2.h / 2}");
    Console.WriteLine($"Area = {t2.CalcArea()}");
  }
}
class Triangulo {
  public double b, h;         // Campo ou atributo  
  public double CalcArea() {  // Método
    return b * h / 2;
  }
}