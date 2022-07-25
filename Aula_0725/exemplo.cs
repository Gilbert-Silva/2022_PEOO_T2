using System;

class Program {
  public static void Main() {
    int v = 0;
    string s = "texto";
    foreach(char c in s)
      switch(c) {
        case 'a' : 
        case 'e' : 
        case 'i' : 
        case 'o' : 
        case 'u' : v++; break;
      }
    Console.WriteLine(v);
  }
}