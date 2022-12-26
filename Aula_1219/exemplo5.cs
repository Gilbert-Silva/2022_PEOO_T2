using System;
class Program {
  public static void Main() {
    // Triangulo t = new Triangulo(10, 20);
    Triangulo t = new Triangulo(10, 20);
    t = new Triangulo { Base = 10, Altura = 20 };
    Console.WriteLine($"Base = {t.Base}");       // Métodos
    Console.WriteLine($"Altura = {t.Altura}");
    Console.WriteLine($"Area = {t.Area}");
    Console.WriteLine(t);
    Console.WriteLine(t.ToString());
    // t.SetBase(20);
    t.Base = 20; // set da propriedade                // Propriedades
    // t.SetAltura(40);
    t.Altura = 40;
    Console.WriteLine($"Base = {t.Base}"); // get da propriedade
    Console.WriteLine($"Altura = {t.Altura}");
    Console.WriteLine($"Area = {t.Area}");
    Console.WriteLine(t);
    //t.Area = 100;
    //string s = "Programação";
    //s.Length = 18;
  }
}
class Triangulo {
  public Triangulo() { }
  public Triangulo(double x, double y) {
    Base = x;
    Altura = y;
  }
  public override string ToString() {
    return $"Base = {Base}, Altura = {Altura}";
  }
  public double Base { get; set; }
  public double Altura { get; set; }
  public double Area {
    get { return Base * Altura / 2; }
  }
}