using System;

class Program {
  public static void Main() {
    int dia = DateTime.Now.Day;
    int mes = DateTime.Now.Month;
    int ano = DateTime.Now.Year;
    Console.WriteLine(dia);
    Console.WriteLine(mes);
    Console.WriteLine(ano);

    //string[] v = Console.ReadLine().Split('/');
      
    
    string s = Console.ReadLine();
    //s.Split('/');
    while (!string.IsNullOrEmpty(s)) {



      
      s = Console.ReadLine();
    }
  }
}