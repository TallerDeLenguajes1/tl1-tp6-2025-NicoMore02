[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)

# Respuestas a las preguntas de la práctica #

## ¿String es una tipo por valor o un tipo por referencia?
-Es de tipo referencia ya que cuando se asigna un valor a una variable de tipo string, se crea una copia de la referencia y no una copia de los datos.

## ¿Qué secuencias de escape tiene el tipo string?
Las secuencias de escape que tiene el tipo string son:
- \n: nueva línea
- \t: tabulador
- \r: retorno de carro (carriage return)
- \b: Retroceso (backspace)
- \f: form feed (salto de página)
- \\": comillas dobles
- \': comillas simples
- \a: alerta (no está soportada en todos los sistemas operativos)
- \v: tabulador vertical (no está soportada en todos los sistemas operativos)
- \uXXXX Unicode (4 dígitos hexadecimales)
- \xXX Unicode (1–4 dígitos hexadecimales)

## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
Cuando se utiliza el carácter @ antes de una cadena de texto, Indica que la cadena se escribe tal como está, sin interpretar secuencias de escape (\n, \\, etc.). Cuando se utiliza el carácter $ antes de una cadena de texto, Permite interpolación de variables y expresiones dentro del texto, usando {}.