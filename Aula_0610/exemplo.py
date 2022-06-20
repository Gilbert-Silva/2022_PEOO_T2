x = "texto"
y = 1
z = 2.5
w = True
c = 'a'

soma = y + z
sub  = y - z
mul  = y * z
div  = y / z
pot  = 2 ** 3
print(soma)
print(sub)
print(mul)
print(div)
print(pot)

print(x)
print(y)
print(z)
print(w)
print(c)

print(type(x))
print(type(y))
print(type(z))
print(type(w))
print(type(c))

x = int(input())
print(x)
print(type(x))

if x < 0:
  print(f"valor informado {x} é negativo")
#else:
#  if x == 0:
elif x == 0:  
  print("valor informado é zero")
else:  
  print(f"valor informado {x} é positivo")

y = float(input())
print(y)
print(type(y))

print(f"{y:.2f}")
print(f"{y:0.2f}")

x = 1
while x <= 10:
  print(x)
  x += 1

s = "Informática"
for c in s:
   print(c)

for x in range(0, 11):
  print(x)
  



