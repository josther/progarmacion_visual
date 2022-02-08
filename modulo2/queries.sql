SELECT titulo, precio, categoria FROM `libros` WHERE precio = 10 OR precio = 20 AND categoria = "business" OR categoria = "mod_cook"
SELECT DISTINCT tipo FROM `libros` WHERE categorias = Algodata Infosystems.
SELECT titulo, cantidad_vendida FROM `libros` WHERE cantidad_vendida < 4000;
SELECT titulo, cantidad_vendida, precio, categoria  FROM `libros` WHERE cantidad_vendida = 1000 AND precio > 10 OR categoria = "business" OR categoria ="mod_cook"
SELECT titulo, categoria, cantidad_vendida FROM `libros` WHERE cantidad_vendida = 4000 OR cantidad_vendida = 5000;
SELECT titulo, categoria, precio FROM `libros` WHERE categoria = "psychology" AND precio > 20
SELECT titulo, precio FROM `libros` WHERE precio = 10 OR precio = 20.
SELECT nombre, estado FROM `tiendas` WHERE estado="wa"


SELECT titulo, precio FROM `libros` WHERE precio > 10
SELECT titulo, categoria FROM `libros` WHERE categoria = "business"
SELECT titulo FROM `libros` WHERE titulo = "computer"
SELECT titulo, categoria, precio FROM `libros` WHERE categoria = "psychology" AND precio < 20
SELECT titulo, categoria, precio FROM libros WHERE categoria = "psychology" AND precio > 20 OR titulo = "computer"