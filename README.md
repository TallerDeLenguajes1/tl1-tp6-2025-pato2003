
# Ejercicio 4

1) ¿String es una tipo por valor o un tipo por referencia?
2) ¿Qué secuencias de escape tiene el tipo string?
3) ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?


## Respuestas

1) String es un tipo por referencia ya que se trata de una coleccion secuencial de solo lectura de objetos char.
2) 
| Secuencia de escape | Nombre de carácter                         | Codificación Unicode                     |
|---------------------|-------------------------------------------|------------------------------------------|
| `\'`               | Comilla simple                            | 0x0027                                  |
| `\"`               | Comilla doble                             | 0x0022                                  |
| `\\`               | Barra invertida                          | 0x005C                                  |
| `\0`               | Nulo                                     | 0x0000                                  |
| `\a`               | Alerta                                   | 0x0007                                  |
| `\b`               | Retroceso                                | 0x0008                                  |
| `\e`               | Escapar                                  | 0x001B                                  |
| `\f`               | Avance de página                         | 0x000C                                  |
| `\n`               | Nueva línea                              | 0x000A                                  |
| `\r`               | Retorno de carro                        | 0x000D                                  |
| `\t`               | Tabulación horizontal                    | 0x0009                                  |
| `\v`               | Tabulación vertical                      | 0x000B                                  |
| `\u`               | Secuencia de escape Unicode (UTF-16)    | \uHHHH (intervalo: 0000 - FFFF; ejemplo: \u00E7 = "ç") |
| `\U`               | Secuencia de escape Unicode (UTF-32)    | \U00HHHHHH (intervalo: 00000 - 10FFFF; ejemplo: \U0001F47D = "👽") |
| `\x`               | Secuencia de escape Unicode similar a "\u" excepto con longitud variable | \xH[H[H[H]]]] (intervalo: 0 - FFFF; ejemplo: \x00E7 o \xE7 = "ç") |

3) Cuando se coloca el @ antes de una cadena de texto, la cadena se convierte en literal, es decir que, por ejempli, podria escribir varias lineas y esas lineas se mantienen igual en el codigo. 
Cuando se agrega el caracter $ antes de una cadena de texto se puede insertar valores de variables dentro de la cadena de texto al poner el nombre de la variable que quiera usar entre {} en el lugar que se desee de la cadena. Esto se llama interpolación

