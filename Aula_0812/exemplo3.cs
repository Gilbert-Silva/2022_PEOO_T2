using System;

class Program {
  public static void Main() {
    double x = double.Parse( Console.ReadLine() );
    double y = double.Parse( Console.ReadLine() );
    double z = (x * 3.5 + y * 7.5) / (3.5 + 7.5);
    Console.WriteLine($"MEDIA = {z:0.00000}");
    Console.WriteLine($"MEDIA = {z:f5}");
  }
}