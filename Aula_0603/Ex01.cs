using System;

public class Program { 
  public static void Main(string[] args) { 
    double a = double.Parse(Console.ReadLine()); 
    double b = double.Parse(Console.ReadLine()); 
    Console.WriteLine($"{a/b:0.00}");

    double c = a / b;
    Console.WriteLine(c.ToString("0.00"));
    Console.WriteLine($"{c:0.00}");
    Console.WriteLine($"{c:f2}");
  } 
} 