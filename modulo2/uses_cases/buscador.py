# pedir al usuario un nombre para buscar y mostrar la cantidad de resultados y los nombres y sus apellidos
print("digita el nombre a buscar:")
nombre = input()


import mysql.connector

mydb = mysql.connector.connect(
  host="localhost",
  user="root",
  password="",
  database="infotep"
)

mycursor = mydb.cursor()

sql = "SELECT * FROM `usuarios` WHERE name LIKE %s"
adr = ("%"+nombre+"%", )

mycursor.execute(sql, adr)

myresult = mycursor.fetchall()

print("\ncantidadde resultados: ",mycursor.rowcount ,"\n")

print("{:<10} {:<10}".format("Nombres", "Apellidos"))

print("-"*25)
for x in myresult:
  print(x[0], x[1])
  
print("{:<10} {:<10}".format("Albert", "Garcia"))
print("{:<10} {:<10}".format("Marlint", "Vasques"))
print("{:<10} {:<10}".format("Aracelis", "Severino"))