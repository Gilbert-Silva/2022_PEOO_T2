using System;
class Program {
  public static void Main() {
    // Triangulo t = new Triangulo(10, 20);
    Triangulo t = new Triangulo { Base = 10, Altura = 20 };
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
  private double b, h;             // Atributos
  public override string ToString() {
    return $"Base = {b}, Altura = {h}";
  }
  public double Base {
    set { if (value > 0) b = value; }
    get { return b; }
  }
  public double Altura {
    // set { if (value > 0) h = value; }
    set => h = value > 0 ? value : 0;
    // get { return h; }
    get => h;
  }
  public double Area {
    get { return b * h / 2; }
  }
}