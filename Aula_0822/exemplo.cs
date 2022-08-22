using System;

class Program {
  public static void Main() {
    int x = 5;
    Console.WriteLine(x);
    Triangulo y = new Triangulo();
    Triangulo z = new Triangulo();
    Console.WriteLine(y);
    Console.WriteLine(y.GetBase());
    Console.WriteLine(y.GetAltura());
    y.SetBase(10);
    y.SetAltura(20);
    Console.WriteLine(y.GetBase());
    Console.WriteLine(y.GetAltura());
    Console.WriteLine(y.CalcArea());

    Console.WriteLine(z);
    Console.WriteLine(z.GetBase());
    Console.WriteLine(z.GetAltura());
    z.SetBase(-30);
    z.SetAltura(40);
    Console.WriteLine(z.GetBase());
    Console.WriteLine(z.GetAltura());
    Console.WriteLine(z.CalcArea());
  }
}

class Triangulo {
  private double b = 1;  // Atributo - Campo
  private double h = 1; 
  public void SetBase(double v)   { if (v > 0) b = v; }
  public void SetAltura(double v) { if (v > 0) h = v; }
  public double GetBase()   { return b; }
  public double GetAltura() { return h; }
  public double CalcArea() { // Método - Operação
    double area = b * h / 2;
    return area;
  }
}


