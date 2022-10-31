using System;

class Program {
  public static void Main() {
    string s = "Técnico em Informática para Internet";
    s.Split();
    // string.Split() se Split fosse static
    Console.WriteLine("Olá");
    int x = 5;
    int y = 15;
    Console.WriteLine(x);
    Console.WriteLine(y);
    
    Aluno a1 = new Aluno();
    a1.nome = "Renan";
    //a1.idade = 16;
    a1.SetIdade(16);
    Aluno a2 = new Aluno();
    a2.nome = "Maria";
    //a2.idade = -18;
    a2.SetIdade(-18);
    Console.WriteLine(a1);
    Console.WriteLine(a1.nome);
//    Console.WriteLine(a1.idade);
    Console.WriteLine(a1.GetIdade());
    Console.WriteLine(a2);
    Console.WriteLine(a2.nome);
//    Console.WriteLine(a2.idade);
    Console.WriteLine(a2.GetIdade());
  
  }
}

class Aluno {
  public string nome;
  private int idade;
  public void SetIdade(int x) {
    if (x > 0) idade = x;
  }
  public int GetIdade() {
    return idade;
  }
}
