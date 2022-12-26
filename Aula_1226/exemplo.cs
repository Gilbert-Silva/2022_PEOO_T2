using System;
class Program {
  public static void Main() {
    Turma t = new Turma { 
      Id = 1, Curso = "InfoWeb", 
      Descricao = "2º Ano", AnoLetivo = 2022 };
    Console.WriteLine(t);
  }
}
class Turma {
  public int Id { get; set; }
  public string Curso { get; set; }
  public string Descricao { get; set; }
  public int AnoLetivo { get; set; }
  public override string ToString() {
    return $"{Id} - {Curso} - {Descricao} - {AnoLetivo}";
  }  
}