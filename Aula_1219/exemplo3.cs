using System;
class Program {
  public static void Main() {
    Triangulo t = new Triangulo(10, 20);
    Console.WriteLine($"Base = {t.GetBase()}");       // Métodos
    Console.WriteLine($"Altura = {t.GetAltura()}");
    Console.WriteLine($"Area = {t.CalcArea()}");
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
  private double b, h;             // Atributos
  public Triangulo(double v1, double v2) { // Construtor
    if (v1 > 0) b = v1;
    if (v2 > 0) h = v2;
  }
  public override string ToString() {
    return $"Base = {b}, Altura = {h}";
  }
  public double Base {
    set { if (value > 0) b = value; }
    get { return b; }
  }
  public void SetBase(double v) {  // Métodos
    if (v > 0) b = v;
  }
  public double GetBase() {
    return b;
  }
  public double Altura {
    set { if (value > 0) h = value; }
    get { return h; }
  }
  public void SetAltura(double v) {
    if (v > 0) h = v;
  }
  public double GetAltura() {
    return h;
  }
  public double Area {
    get { return b * h / 2; }
  }
  public double CalcArea() {
    return b * h / 2;
  }
}