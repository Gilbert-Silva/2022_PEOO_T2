using System;
class Program {
  public static void Main() {
    Triangulo t = new Triangulo();
    t.SetBase(10);
    t.SetAltura(20);
    Console.WriteLine($"Base = {t.GetBase()}");
    Console.WriteLine($"Altura = {t.GetAltura()}");
    Console.WriteLine($"Area = {t.CalcArea()}");
  }
}
class Triangulo {
  private double b, h;             // Atributos
  public void SetBase(double v) {  // Métodos
    if (v > 0) b = v;
  }
  public double GetBase() {
    return b;
  }
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