using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite seu nome");
    string nome = Console.ReadLine();
    nome = FormatarNome(nome);
    Console.WriteLine(nome);

    Console.WriteLine("Digite sua cidade");
    string cidade = Console.ReadLine();
    cidade = FormatarNome(cidade);
    Console.WriteLine(cidade);
  }
  public static string FormatarNome(string nome) {
    string[] v = nome.ToLower().Split();
    string r = "";
    foreach (string s in v) {
      switch(s) {
        case "da":  case "de":  case "do":  case "das":
        case "dos": case "e": r = r + s + " "; break;
        case "i" : r += "I "; break;  
        case "ii" : r += "II "; break;  
        case "iii" : r += "III "; break;  
        case "iv" : r += "IV "; break;  
        default: 
          if (s != "")
            r = r + s.Substring(0, 1).ToUpper() + 
                s.Substring(1) + " ";
          break;
      }
    }
    return r;
  }
}

/*
    string[] v = nome.ToLower().Split();
    string r = "";
    foreach (string s in v) {
      //Console.WriteLine(s[0]);            // 1ª letra - char
      //Console.WriteLine(s.Substring(0, 1).ToUpper() + 
      //                  s.Substring(1));    // 1ª letra - string
      switch(s) {
        case "da":
        case "de":
        case "do":
        case "das":
        case "dos":
        case "e": r = r + s + " "; break;
        default: 
          if (s != "")
            r = r + s.Substring(0, 1).ToUpper() + 
                s.Substring(1) + " ";
          break;
      }
    }
    Console.WriteLine(r);

*/