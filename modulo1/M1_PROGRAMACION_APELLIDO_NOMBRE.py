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
multiplicacion = []
division = []

for x in range(1):
  print("colocar la suma, resta, division, multiplicacion ")

  if listado > suma :
    listado = input()
    print("Resultado de la suma")
    print(numero1+numero2)

  if listado < resta :
    listado = input()
    print("Resultado de la resta")
    print(numero1-numero2)

  if listado >= multiplicacion:
    listado = input()  
    print("Resultado de la multiplicacion")
    print(numero1*numero2)

  if listado == division:
    listado = input()
    print("Resultado de la division")
    print(numero1%numero2)