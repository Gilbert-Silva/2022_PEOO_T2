class Musica:
  def __init__(self, t, a, al):
    self.titulo = t
    self.artista = a
    self.album = al
  def __str__(self):
    return f"{self.titulo} - {self.artista} - {self.album}"

m1 = Musica("Easy", "Ivete", "Ao vivo")
print(m1)
m2 = Musica("Transilvania", "Iron Maiden", "IM")
print(m2)
m3 = m1
print(m3)
m3.titulo = "Berimbau"
print(m1)


