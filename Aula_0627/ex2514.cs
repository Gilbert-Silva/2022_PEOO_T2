using System;

class Program {
  public static void Main() {
    string s;
    s = Console.ReadLine();
    while (string.IsNullOrEmpty(s) == false) {
      int m = int.Parse(s);
      string[] v = Console.ReadLine().Split();
      int l1 = int.Parse(v[0]);
      int l2 = int.Parse(v[1]);
      int l3 = int.Parse(v[2]);
      Console.WriteLine(s);
      s = Console.ReadLine();
    }
  }
}
