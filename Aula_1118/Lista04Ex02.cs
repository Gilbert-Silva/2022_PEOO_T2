using System;
class Program {
  public static void Main() {
    Musica m1 = new Musica("Easy", "Ivete", "Ao vivo");
    Musica m2 = new Musica("Berimbau", "Ivete", "Ao vivo");
    Musica m3 = new Musica("Transilvania", "Iron Mained", "IM");
    PlayList lista = new PlayList("POO");
    lista.Inserir(m1);
    lista.Inserir(m2);
    lista.Inserir(m3);
    foreach(Musica m in lista.Listar())    
      Console.WriteLine(m);
    /*
    Musica[] v = new Musica[10];
    v[0] = m1;
    v[1] = m2;
    v[2] = new Musica("Transilvania", "Iron Mained", "IM");
    foreach(Musica m in v)    
      if (m != null) Console.WriteLine(m);
    */
  }
}
class PlayList {
  private string nome;
  private int k = 0;
  private Musica[] musicas = new Musica[1];
  public PlayList(string n) {
    nome = n;
  }
  public void Inserir(Musica m) {
    if (k == musicas.Length) 
      Array.Resize(ref musicas, musicas.Length * 2);
    musicas[k] = m;
    k++;
  }
  public Musica[] Listar() {
    Musica[] vetor = new Musica[k];
    Array.Copy(musicas, vetor, k);
    return vetor;
  }
}
class Musica {
  private string titulo;
  private string artista;
  private string album;
  public Musica(string t, string a, string al) {
    titulo = t;
    artista = a;
    album = al;
  }
  public void SetTitulo(string t) {
    titulo = t;
  }
  public override string ToString() {
    return $"{titulo} - {artista} - {album}";
  }
}
