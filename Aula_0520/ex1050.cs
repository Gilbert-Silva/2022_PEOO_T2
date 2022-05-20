using System;
class Program {
  public static void Main() {
    int n = int.Parse(Console.ReadLine());
    switch(n) {  // match 3.10
      case 61: Console.WriteLine("Brasilia"); break;
      case 71: Console.WriteLine("Salvador"); break;
      case 11: Console.WriteLine("Sao Paulo"); break;
      case 21: Console.WriteLine("Rio de Janeiro"); break;
      case 32: Console.WriteLine("Juiz de Fora"); break;
      case 19: Console.WriteLine("Campinas"); break;
      case 27: Console.WriteLine("Vitoria"); break;
      case 31: Console.WriteLine("Belo Horizonte"); break;
      default: Console.WriteLine("DDD nao cadastrado"); break;
    }
  }
  public static void Main3() {
    int n = int.Parse(Console.ReadLine());
    if (n == 61) Console.WriteLine("Brasilia");
    //elif (n == 71) Console.WriteLine("Salvador");    
    else if (n == 71) Console.WriteLine("Salvador");    
    else if (n == 11) Console.WriteLine("Sao Paulo"); 
    else if (n == 21) Console.WriteLine("Rio de Janeiro");
    else if (n == 32) Console.WriteLine("Juiz de Fora");
    else if (n == 19) Console.WriteLine("Campinas");
    else if (n == 27) Console.WriteLine("Vitoria");
    else if (n == 31) Console.WriteLine("Belo Horizonte");
    else Console.WriteLine("DDD nao cadastrado");
  }

  public static void Main2() {
    int n = int.Parse(Console.ReadLine());
    if (n == 61) Console.WriteLine("Brasilia");
    if (n == 71) Console.WriteLine("Salvador");    
    if (n == 11) Console.WriteLine("Sao Paulo"); 
    if (n == 21) Console.WriteLine("Rio de Janeiro");
    if (n == 32) Console.WriteLine("Juiz de Fora");
    if (n == 19) Console.WriteLine("Campinas");
    if (n == 27) Console.WriteLine("Vitoria");
    if (n == 31) Console.WriteLine("Belo Horizonte");
    bool b = n != 61 && n != 71 && n != 11 && n != 21 && 
             n != 32 && n != 19 && n != 27 && n != 31;
    if (b) Console.WriteLine("DDD nao cadastrado");
  }
}

/*
bool aprovado  = media >= 60 && frequencia >= 0.75;
bool reprovado = media < 60 || frequencia < 0.75;

reprovado = !aprovado;
            !(media >= 60 && frequencia >= 0.75)
              (media < 60 || frequencia < 0.75)
-(2 + 4 - 6) = (-2 - 4 + 6)
*/  
  
