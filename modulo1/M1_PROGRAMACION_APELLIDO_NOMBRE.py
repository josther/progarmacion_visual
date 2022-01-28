print("Nombre del autor")
print("Josué David Cruz Parra")

print("Digite su nombre")
nombre = input()
print("Digite su edad")
edad = int(input())

print("Digite un numero")
numero1 = int(input())

print("Digite un numero")
numero2 = int(input())

operaciones = ["suma", "resta", "division", "multiplicacion",]

for i in range(1):
  
  if operaciones == 0:
    print("coloque un numero del 1 al 4")
    operaciones = int(input())
    print("Resultado de la suma")
    print(numero1+numero2)

  # print(operaciones[1])
  # print("Resultado de la resta")
  # print(numero1-numero2)
 
  # print(operaciones[2])
  # print("Resultado de la multiplicacion")
  # print(numero1*numero2)

  # print(operaciones[3])
  # print("Resultado de la division")
  # print(numero1%numero2)