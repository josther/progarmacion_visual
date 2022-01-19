#pedirle al usuario que diguite 10 numeros y al final mostrar los numeros pares de los digitados.
print("ingrese un numero")
numero = int(input())
a = []
b = []
for i in range(1,numero+1):
  n = int(input("ingrese numero{}: ".format(i)))
  if n >= 0 and n <= 10:
    if n%2 == 0:
      a.append(n)
    else:
      b.append(n)
  else:
    print("error, el numero no esta comprendido dentro del rango")
    break
print("Hay {} numero pares".format(len(a)))
print("Hay {} numero impares".format(len(b)))