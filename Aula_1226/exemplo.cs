using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

class Program {
  public static void Main() {
    Console.WriteLine("1-Inserir, 2-Listar, 3-Salvar, 4-Abrir, 0-Fim");
    int op = int.Parse(Console.ReadLine());
    while (op != 0) {
      switch(op) {
      case 1:
        Console.Write("Informe o Id: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Informe o curso: ");
        string curso = Console.ReadLine();
        Console.Write("Informe a descrição da turma: ");
        string desc = Console.ReadLine();
        Console.Write("Informe o ano letivo: ");
        int ano = int.Parse(Console.ReadLine());
        Turma t = new Turma { Id = id, Curso = curso, 
          Descricao = desc, AnoLetivo = ano };
        NTurma.Inserir(t);
        break;    
      case 2:
        foreach(Turma x in NTurma.Listar())
          Console.WriteLine(x); 
        break;
      case 3:
        NTurma.Salvar();
        break;
      case 4:
        NTurma.Abrir();
        break;
      }      
      Console.WriteLine("1-Inserir, 2-Listar, 3-Salvar, 4-Abrir, 0-Fim");
      op = int.Parse(Console.ReadLine());
    }
  }
}
public class Turma {
  public int Id { get; set; }
  public string Curso { get; set; }
  public string Descricao { get; set; }
  public int AnoLetivo { get; set; }
  public override string ToString() {
    return $"{Id} - {Curso} - {Descricao} - {AnoLetivo}";
  }  
}
static class NTurma {
  // private Turma[] turmas = new Turma[10];
  private static List<Turma> turmas = new List<Turma>();
  public static void Inserir(Turma t) { // C - Create
    turmas.Add(t);
  }
  public static List<Turma> Listar() { // R - Read
    return turmas;
  }
  public static void Atualizar(Turma t) { // U - Update
    
  }
  public static void Excluir(Turma t) { // D - Delete
    
  }
  public static void Abrir() {
    XmlSerializer xml = new XmlSerializer(typeof(List<Turma>));
    StreamReader f = new StreamReader("./turma.xml");
    turmas = (List<Turma>) xml.Deserialize(f);
    f.Close();
  }
  public static void Salvar() {
    XmlSerializer xml = new XmlSerializer(typeof(List<Turma>));
    StreamWriter f = new StreamWriter("./turma.xml", false);
    xml.Serialize(f, turmas);
    f.Close();
  }
}