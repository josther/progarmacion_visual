# conexion con la base de datos

#1. importar la libreria
import  mysql.connector
import os

#2.establecer la conexion
conexion = mysql.connector.connect(
  host = "localhost",
  user = "root",
  passwd = "",
  db = "sakila"
)

#3.definir el cursor
cursor = conexion.cursor()


print("""
eligela operacion a realizar con los actores

1.mostar todos los actores
2.insertar nuevo actor
3.actualizar informacion de actor
4.eleiminar un actor
5.buscar un actor por su id
6.buscar actores por nombre

""")

opcion = input()

#limpiar la terminal
os.system("clear")

# imprimir la opcion del usuario
print("opcion eligida;", opcion)

if opcion == "1":
  print("mostrar todos los actores")

  sql = "SELECT first_name,last_name FROM actor;"

  cursor.execute(sql)

  actores = cursor.fetchall()

  print("cantidad", cursor.rowcount)

  for actor in actores:
    print(actor)

if opcion == "2":
  print("Insertar nuevo actor")
  actor = input()

  print("insertar apellido del nuevo actor")
  apellido = input()

  sql = "insert into actor (first_name, last_name) values (%s,%s)"

  valores = [actor, apellido]

  actor = cursor.execute(sql, valores)

  conexion.commit()



if opcion == "3":
  print("actualizar informacion de actor")
  actor = input()

  print("apellido del actor")
  apellido = input()

  sql = "update into actor (first_name, last_name) values (%s,%s)"

  valores = [actor, apellido]

  actor = cursor.execute(sql, valores)

  conexion.commit()




if opcion == "4":
    print("eliminar un actor")

    sql = "delete FROM actor (first_name) values (%s)"


if opcion == "5":
    print("buscar un actor por su id")



if opcion == "6":
    print("buscar actores por nombre")            


