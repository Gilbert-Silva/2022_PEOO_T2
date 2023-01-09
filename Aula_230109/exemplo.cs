using System;
using System.Collections.Generic;  // List
using System.Xml.Serialization;    // XmlSerializer
using System.IO;                   // StreamReader, StreamWriter

class Program {
  public static void Main() {
    File.Delete("./turma.xml");
    File.Delete("./aluno.xml");
    Aluno a1 = new Aluno {
      Id = 1, Nome = "Renan", Matricula = "1234", Email = "renan@email.com" };
    Aluno a2 = new Aluno {
      Id = 2, Nome = "Luiza", Matricula = "4321", Email = "luiza@email.com" };
    Aluno a3 = new Aluno {
      Id = 3, Nome = "Felipe", Matricula = "8888", Email = "felipe@email.com" };
    Turma t1 = new Turma {
      Id = 1, Curso = "InfoWeb", Descricao = "2º Ano", AnoLetivo = 2022 };
    Turma t2 = new Turma {
      Id = 2, Curso = "TADS", Descricao = "2º Semestre", AnoLetivo = 2022 };
    NAluno.Inserir(a1);
    NAluno.Inserir(a2);
    NAluno.Inserir(a3);
    NTurma.Inserir(t1);
    NTurma.Inserir(t2);
    NAluno.Matricular(a1, t1);
    NAluno.Matricular(a2, t1);
    NAluno.Matricular(a3, t2);
    Console.WriteLine("Alunos da turma: " + t1);
    foreach(Aluno a in NAluno.Listar(t1))
      Console.WriteLine("  " + a);
    Console.WriteLine("Alunos da turma: " + t2);
    foreach(Aluno a in NAluno.Listar(t2))
      Console.WriteLine("  " + a);
    Console.WriteLine("Todos os Alunos");
    foreach(Aluno a in NAluno.Listar())
      Console.WriteLine("  " + a);
    Console.WriteLine(NAluno.Listar(1));
    
  }
}

public class Turma
{
  public int Id { get; set; }
  public string Curso { get; set; }
  public string Descricao { get; set; }
  public int AnoLetivo { get; set; }
  public override string ToString()
  {
      return $"{Id} - {Curso} - {Descricao} - {AnoLetivo}";
  }
}

public class Aluno
{
  public int Id { get; set; }
  public string Nome { get; set; }
  public string Matricula { get; set; }
  public string Email { get; set; }
  public int IdTurma { get; set; }
  public override string ToString()
  {
      return $"{Id} - {Nome} - {Matricula} - {Email}";
  }
}

static class NTurma
{
    private static List<Turma> turmas = new List<Turma>();
    public static void Inserir(Turma t)
    { // C - Create
        Abrir();
        turmas.Add(t);
        Salvar();
    }
    public static List<Turma> Listar()
    { // R - Read
        Abrir();
        return turmas;
    }
    public static Turma Listar(int id)
    {
        // Encontra, se existir, uma turma com o id
        foreach (Turma obj in turmas)
            if (obj.Id == id) return obj;
        return null;
    }
    public static void Atualizar(Turma t)
    { // U - Update
        Abrir();
        Turma obj = Listar(t.Id);
        obj.Curso = t.Curso;
        obj.Descricao = t.Descricao;
        obj.AnoLetivo = t.AnoLetivo;
        Salvar();
    }
    public static void Excluir(Turma t)
    { // D - Delete
        Abrir();
        turmas.Remove(Listar(t.Id));
        Salvar();
    }
    public static void Abrir()
    {
        StreamReader f = null;
        try
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Turma>));
            f = new StreamReader("./turma.xml");
            turmas = (List<Turma>)xml.Deserialize(f);
        }
        catch
        {
            turmas = new List<Turma>();
        }
        if (f != null) f.Close();
    }
    public static void Salvar()
    {
        XmlSerializer xml = new XmlSerializer(typeof(List<Turma>));
        StreamWriter f = new StreamWriter("./turma.xml", false);
        xml.Serialize(f, turmas);
        f.Close();
    }
}

static class NAluno
{
    private static List<Aluno> alunos = new List<Aluno>();
    public static void Inserir(Aluno t)
    { // C - Create
        Abrir();
        alunos.Add(t);
        Salvar();
    }
    public static List<Aluno> Listar()
    { // R - Read
        Abrir();
        return alunos;
    }
    public static Aluno Listar(int id)
    {
        // Encontra, se existir, uma turma com o id
        foreach (Aluno obj in alunos)
            if (obj.Id == id) return obj;
        return null;
    }
    public static void Atualizar(Aluno t)
    { // U - Update
        Abrir();
        Aluno obj = Listar(t.Id);
        obj.Nome = t.Nome;
        obj.Matricula = t.Matricula;
        obj.Email = t.Email;
        obj.IdTurma = t.IdTurma;
        Salvar();
    }
    public static void Excluir(Aluno t)
    { // D - Delete
        Abrir();
        alunos.Remove(Listar(t.Id));
        Salvar();
    }
    public static void Abrir()
    {
        StreamReader f = null;
        try
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Aluno>));
            f = new StreamReader("./aluno.xml");
            alunos = (List<Aluno>)xml.Deserialize(f);
        }
        catch
        {
            alunos = new List<Aluno>();
        }
        if (f != null) f.Close();
    }
    public static void Salvar()
    {
        XmlSerializer xml = new XmlSerializer(typeof(List<Aluno>));
        StreamWriter f = new StreamWriter("./aluno.xml", false);
        xml.Serialize(f, alunos);
        f.Close();
    }
    public static void Matricular(Aluno a, Turma t) {
      a.IdTurma = t.Id;      
      Atualizar(a);
    }
    public static List<Aluno> Listar(Turma t)
    {
        Abrir(); // Abre a lista com todos os alunos
        List<Aluno> diario = new List<Aluno>(); // Lista de alunos da turma t
        foreach (Aluno obj in alunos)
            if (obj.IdTurma == t.Id) diario.Add(obj);
        return diario;
    }
}

