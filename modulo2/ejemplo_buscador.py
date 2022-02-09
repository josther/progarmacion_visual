print("digite el nombre del pais que desea buscar: ")
nombre_pais = input()

print("buscando registro que coincida con:", nombre_pais)

import mysql.connector

conexion = mysql.connector.connect(
  host = "localhost",
  user = "root",
  passwd = "",
  db = "sakila"
)

cursor = conexion.cursor()


cursor.execute("SELECT country FROM `country` WHERE country LIKE '%"+nombre_pais+"%' ")

resultado = cursor.fetchall()

for registros in resultado:
  print(registros)

