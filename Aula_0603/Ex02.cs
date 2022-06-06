using System;

public class Program { 
  public static void Main(string[] args) { 
    int a = int.Parse(Console.ReadLine()); 
    int b = int.Parse(Console.ReadLine()); 
    int c = int.Parse(Console.ReadLine()); 
    int d = int.Parse(Console.ReadLine()); 
    int soma = 0;
    if (a >= 0) soma = soma + a; 
    if (b >= 0) soma = soma + b;
    if (c >= 0) soma = soma + c;
    if (d >= 0) soma = soma + d;
    Console.WriteLine(soma);
  }  
} 