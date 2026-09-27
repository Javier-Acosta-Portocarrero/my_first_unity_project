# Práctica 1 Unity - Interfaces Inteligentes

Autor: Javier Acosta Portocarrero

Esta práctica ha sido mi primera toma en contacto con Unity (omitienda la primera hora práctica de la asignatura), en este informe hablaré sobre los principales conceptos aprendidos, dvidiré los aprendizajes más importantes por ejercicios.

## Ejercicio 1

En este ejercicio me familiaricé más con la sintaxis de C# y el entorno de Unity.

Aprendí a crear atributos públicos y a modificarlos desde la interfaz de Unity, además de a usar la clase Vector3 para almacenar, en este caso, la representación de un color RGB, y a usar la clase Random para generar valores aleatorios (entre 0 y 1, que es el mismo rango que usa la clase Color para representar los colores). También me familiaricé con la función Update de los GameObject, que se ejecuta en cada frame de la ejecución.

Por último, destaco el uso de la función GetComponent para obtener una referencia de los componentes de un GameObject y poder modificar sus atributos desde el script.

Prueba de ejecución de este ejercicio:
![Gif Ejercicio 1](./gifs-readme/ejercicio1.gif)

## Ejercicio 2

Este ejercicio profundiza especialmente en el uso de la clase Vector3, incluyendo en su inicialización, y en sus métodos estáticos que facilitan el cálculo de magnitudes, ángulos y distancias entre vectores. También se ha hecho uso de sus atributos, incluyendo tanto los valores de sus componentes como el valor de su magnitud.

Prueba de ejecución de este ejercicio:
![Gif Ejercicio 2](./gifs-readme/ejercicio2.gif)

## Ejercicio 3

Este ejercicio, además de usar los conceptos introcudidos por los anteriores, como el uso de Vector3, introduce el uso de transform, que es una propiedad de los GameObject que permite acceder, entre otros datos, a su posición. También introduce la posibilidad de mostrar datos en pantalla, para lo que he usado GUI.Label, lo cual nos permite mostrar un texto en pantalla en la posición que se le indique, permitiendo a su vez indicar tamaño de fuente, anchura, altura, color del texto, etc.

Prueba de ejecución de este ejercicio:
![Gif Ejercicio 3](./gifs-readme/ejercicio3.gif)

## Ejercicio 4

Además de también reforzar concetos mencionados anteriormente (uso de Vector3.distancae y transform, etc), este ejercicio me ha enseñado a usar la función GameObject.FindWithTag, que permite obtener una referencia a un GameObject a partir de su tag, lo cual es muy útil para poder interactuar con otros GameObjects sin necesidad de tener referencias directas a ellos. He aprendido a crear tags desde la misma interfaz de Unity y también a asignarlos a los GameObjects.

Prueba de ejecución de este ejercicio:
![Gif Ejercicio 4](./gifs-readme/ejercicio4.gif)