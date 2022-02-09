print("conexion sakila")

#importar la libreria de mysql para poder conectarnos
import mysql.connector

#establecemos la conexion con mysql
conexion = mysql.connector.connect(
    host = "localhost",
    user = "root",
    passwd = "",
    db = "sakila"
)

#el cursor representa la terminal de mysql
cursor = conexion.cursor()

# ejecutar un query (setencia sql)
cursor.execute('select last_name from actor where last_name like "%ss%"')

#guardar una variable todos los resultados del query
for registros in cursor.fetchall() :
    print(registros)

# recorrer lo que hay en resultado
#for registros in resultado:
  #print(registros)

# cerramos la conexion 
conexion.close()