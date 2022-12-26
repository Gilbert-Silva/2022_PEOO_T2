using System;
class Program {
  public static void Main() {
    Triangulo t = new Triangulo(10, 20);
    Console.WriteLine($"Base = {t.GetBase()}");
    Console.WriteLine($"Altura = {t.GetAltura()}");
    Console.WriteLine($"Area = {t.CalcArea()}");
    Console.WriteLine(t);
    t.SetBase(20);
    t.SetAltura(40);
    Console.WriteLine($"Base = {t.GetBase()}");
    Console.WriteLine($"Altura = {t.GetAltura()}");
    Console.WriteLine($"Area = {t.CalcArea()}");
    Console.WriteLine(t);
  }
}
class Triangulo {
  private double b, h;             // Atributos
  public Triangulo(double v1, double v2) { // Construtor
    if (v1 > 0) b = v1;
    if (v2 > 0) h = v2;
  }
  public override string ToString() {
    return $"Base = {b}, Altura = {h}";
  }
  public void SetBase(double v) {  // Métodos
    if (v > 0) b = v;
  }
  //public double GetBase() {
  //  return b;
  //}
  public double GetBase() => b;
  public void SetAltura(double v) {
    if (v > 0) h = v;
  }
  public double GetAltura() {
    return h;
  }
  public double CalcArea() {
    return b * h / 2;
  }
}