# usos de un ciclo

#1. impirmir letras
nombre = "ramona alcachofa"

for letra in nombre:
  print(letra)

#2. imprimir elementos de una lista
listadi_nombres = ['Toshio', 'Marielisa', 'sandro']

for nombre in listado_nombres:
  print(nombre)

######

numeros = [100, 50, 5, 11]

for n in numeros:
  print

#3. imprimir rango de numeros
rango1 = range(40) # rango de 40 numeros (del 0 al 39)
rango2 = range(1,41) # rango de 40 numeros del (1 al 40)
rango3 = range(5,10) # (del 5 al 9) rango de 5 numeros

#4. repetir un codigo
veces = range(5)

#ejecutar codigo 5 veces
for i in veces:
  print("dime tu nombre: ")
  input()

######

print("dime la cantidad de dias que trabajas")
cantidad = int( input() )

for fulano in range(cantidad):
  print("digite el precio ganado: ")
percio = int(input())  

# alternativa
fot fulano in "."*cantidad:
  print("digite el precio ganado: ")
  precio = int(input())