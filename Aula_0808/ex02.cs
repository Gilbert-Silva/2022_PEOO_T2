using System;

class Disciplina {
  public string nome; // atributos
  public int nota1, nota2, nota3, nota4, nf;
  public int MediaParcial() {  // métodos
    return (2 * nota1 + 2 * nota2 + 3 * nota3 + 3 * nota4)/10;   
  }
  public int MediaFinal() {
    int mp = MediaParcial();
    if (mp >= 60) return mp;  // Aprovado por média
    return (mp + nf)/2;       // Em prova final
  }
  public bool Aprovado() {
    return MediaFinal() >= 60;
    //if (MediaFinal() >= 60) return true;
    //else return false;
  }
}

class Program {
  public static void Main() {
    Disciplina x = new Disciplina();
    Console.WriteLine("Digite o nome da disciplina");
    x.nome = Console.ReadLine();
    Console.WriteLine("Digite a nota do 1º bimestre");
    x.nota1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a nota do 2º bimestre");
    x.nota2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a nota do 3º bimestre");
    x.nota3 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a nota do 4º bimestre");
    x.nota4 = int.Parse(Console.ReadLine());
    if (x.MediaParcial() < 60) {
      Console.WriteLine("Digite a nota da prova final");
      x.nf = int.Parse(Console.ReadLine());
    }
    if (x.Aprovado())
       Console.WriteLine($"Aprovado em {x.nome} com média {x.MediaFinal()}");
    else
       Console.WriteLine($"Reprovado em {x.nome} com média {x.MediaFinal()}");
  }
}

