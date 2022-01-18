#print("cuantos numeros de sea ingresar")
#veces = int(input())
#cont = 0
#acum = 0
#for i in range(veces):
  #print("---ciclo "+str(i+1)+"---")
  #print("ingrese un numero")
  #num = int(input()) 
  #if num%2==0:
   # cont+=1 #cont = cont +1    
  #else:
   # acum+=num # acum = acum + num
#print("la cantidad de numeros pares es:", cont)
#print("la suma total de numeros impares es:", acum) 



veces = int(input("cuantos numeros de sea ingresar"))
cont = 0
acum=0
for i in range(veces):
  print("---ciclo "+str(i+1)+"---")
  num = int(input("ingrese un numero"))
  if num%2==0:
    cont+=1
  else:
    acum+=num
print("la cantidad de numeros pares es:", cont)
print("la suma total de numeros impares es:", acum)    