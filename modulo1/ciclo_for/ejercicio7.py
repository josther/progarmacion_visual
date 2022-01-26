#Generar la tabla de multiplicar pidiendo al usuario que digite el valor.
print("digitar tablas de multiplicar")
numero = int(input())

for i in range(1, 21):
  resultado = i * numero
  print(numero, "x"  , i, " = ", resultado)