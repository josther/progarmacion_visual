# el print sirve para impirmir un mensaje en la pantalla

print("Nombre del autor")
print("Josué David Cruz Parra")

print("Digite su nombre")
nombre = input()
print("Digite su edad")
edad = int(input())
print("Digite un numeros")
numero1 = int(input())

print("Digite un numeros")
numero2 = int(input())

listado = []
suma = []
resta = []
multiplicación = []
división = []

for x in range(1):
  print("colocar la suma, resta, división, multiplicación ")

  if listado == suma :
    listado = input()
    print("Resultado de la suma")
    print(numero1+numero2)

  if listado == resta :
    lsitado = input()
    print("Resultado de la resta")
    print(numero1-numero2)

  if listado == multiplicación:  
    print("Resultado de la multiplicación")
    print(numero1*numero2)

  if listado == división:
    print("Resultado de la división")
    print(numero1%numero2)