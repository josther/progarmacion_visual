print("conexion sakila")

import mysql.connector

conexion = mysql.connector.connect(
    hosts = "localhost",
    user = "root",
    passwd = "",
    db = "sakila"
)

cursor = conexion.cursor()

cursor.execute('SELECT * from country')

for registros in cursor.fetchall() :
    print(registros)

conexion.close()