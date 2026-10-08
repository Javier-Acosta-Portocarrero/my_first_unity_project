# Ejercicios 5-13

Autor: Javier Acosta Portocarrero

En esta práctica he aprendido a cómo realizar movimientos en objetos de Unity, a leer inputs (con el sistema legacy) y a cómo gestionar la velocidad y orientación de los objetos en movimiento, entre otros conceptos. En este informe hablaré sobre los principales conceptos aprendidos, dividiré los aprendizajes más importantes por ejercicios.

## Ejercicio 5

Este ejercicio sirvió como toma de contacto con el sistema de inputs legacy de Unity, que permite leer los inputs del teclado y del ratón, y también con el manejo en general del movimiento de los objetos, sumando un vector con el movimiento a la posición actual del transform cada vez que se pulsara la barra espaciadora o si esta se deja mantenida.

Prueba de ejecución de este ejercicio:
![Gif Ejercicio 5](./gifs-readme2/ejercicio5.gif)

## Ejercicio 6

Este ejercicio profundiza especialmente en la lectura de los inputs ```Horizontal``` y ```Vertical``` del sistema de inputs legacy de Unity, que permiten leer los inputs de las teclas de dirección y de las teclas WASD, tanto con el uso de ```Input.GetAxis``` (que permite obtener valores entre -1 y 1) como con ```Input.GetKey```, y también introduce el concepto de velocidad en movimientos, aunque solo para imprimir en pantalla el cual sería el desplazamiento.

Prueba de ejecución de este ejercicio:
![Gif Ejercicio 6](./gifs-readme2/ejercicio6.gif)

## Ejercicio 7

Este ejercicio me ha enseñado a cómo cambiar con qué teclas se activan los inputs del sistema legacy de Unity, especialmente he cambiado con qué botón se activa el input ```fire1```, añadiendo la tecla "h".

Prueba de ejecución de este ejercicio:
![Gif Ejercicio 7](./gifs-readme2/ejercicio7.gif)

## Ejercicio 8

Además de utilizar conceptos mencionados anteriormente (uso de velocidades, cómo aplicar desplazamientos, etc.), este ejercicio ha introducido el método ```Transform.Translate```, que permite aplicar un desplazamiento a la posición del transform, indicado en cada parámetro cuál sería el desplazamiento en cada eje (para lo cual se usa el atributo público ```moveDirection```), teniendo en cuenta la velocidad indicada (multiplicamos el desplazamiento por la velocidad).

Resultados obtenidos para:
- a) Duplicas las coordenadas de la dirección del movimiento: Esto consigue que el objeto se mueva el doble en cada frame, es decir, que se mueva el doble de rápido.
- b) Duplicas la velocidad manteniendo la dirección del movimiento: Esto consigue que el objeto se mueva el doble en cada frame, es decir, que se mueva el doble de rápido, al igual que en el caso anterior.
- c) La velocidad que usas es menor que 1: Esto consigue que el objeto se mueva menos en cada frame, es decir, que se mueva más lento. Si en vez de esto hacemos que la velocidad sea negativa, el objeto se moverá en la dirección opuesta a la indicada por el vector de movimiento.
- d) La posición del cubo tiene y>0: Esto solo consigue que el cubo se mueva en la dirección indicada por el vector de movimiento, no hay ningún efecto especial por tener y>0, más que empezar a moverse desde una posición más alta en el eje y. Si en cambio hacemos que y>0 ```moveDirection``` (el vector de movimiento), también se moverá hacia arriba además de hacia delante (solo tenía un valor distinto de 0 en el eje z antes de aplicar este cambio), ya que el vector de movimiento tiene un componente positivo en el eje y.
- e) Intercambiar movimiento relativo al sistema de referencia local y el mundial: En caso de tener movimiento relativo al sistema de referencia mundial, el objeto se moverá en la dirección indicada por el vector de movimiento, sin importar la orientación del objeto. En cambio, si tenemos movimiento relativo al sistema de referencia local, el objeto se moverá en la dirección indicada por el vector de movimiento, pero teniendo en cuenta la orientación del objeto.

Prueba de ejecución de este ejercicio:
![Gif Ejercicio 8](./gifs-readme2/ejercicio8.gif)

## Ejercicio 9

Este ejercicio usa todos los conceptos anteriores para conseguir mover el cubo haciendo uso de las flechas del teclado (o WASD), haciendo uso de ````transform.Translate````, de una velocidad como atributo público y de ```Input.GetAxis``` para leer los inputs del teclado.

Prueba de ejecución de este ejercicio:
![Gif Ejercicio 9](./gifs-readme2/ejercicio9.gif)

## Ejercicio 10

Este ejercicio me ha enseñado a cómo hacer que los movimientos dependan del tiempo transcurrido en vez de depender del número de frames, para lo cual se ha usado ```Time.deltaTime```, que nos da el tiempo transcurrido desde el último frame, y multiplicando el desplazamiento por este valor conseguimos que el movimiento sea independiente del número de frames. Esto es muy útil, pues la cantidad de frames por segundo puede variar dependiendo del hardware y de la carga de trabajo del sistema, y si no se tiene en cuenta esto, el movimiento podría ser más rápido o más lento dependiendo del equipo donde se ejecute el juego, etc.

Prueba de ejecución de este ejercicio:
![Gif Ejercicio 10](./gifs-readme2/ejercicio10.gif)

## Ejercicio 11

Este ejercicio también hace uso de parte de los conceptos anteriores, para conseguir que el cubo se mueva hacia la posición de la esfera, en vez de usar inputs para conocer la dirección del movimiento, se ha usado ```GameObject.FindWithTag``` para obtener la posición de la esfera y calcular el vector de movimiento como la diferencia entre la posición de la esfera y la posición del cubo. Además, se ha normalizado este vector para que su magnitud sea 1, consiguiendo que el avance no dependa de la distancia entre los dos objetos.

Prueba de ejecución de este ejercicio:
![Gif Ejercicio 11](./gifs-readme2/ejercicio11.gif)

## Ejercicio 12

Partiendo del ejercicio anterior, este ejercicio hace que el cubo se mueva hacia la posición de la esfera, pero además de esto, hace que el cubo mire siempre hacia la esfera, independientemente de la orientación de su sistema de referencia. Para ello, se ha usado ```Transform.LookAt```, que rota al objeto para que el eje z positivo apunte hacia el objetivo (la esfera). Además, se ha usado ```Input.GetAxis``` para leer los inputs del teclado y poder mover la esfera con las teclas WASD.

Prueba de ejecución de este ejercicio:
![Gif Ejercicio 12](./gifs-readme2/ejercicio12.gif)

## Ejercicio 13

Por último, este ejercicio me ha enseñado cómo hacer que un objeto se mueva continuamente (o dependiendo de otro input) siempre hacia el eje z positivo, mientras que con las flechas solo cambiamos la rotación del objeto, haciendo que este eje apunte hacia la dirección que queramos. Para ello, se ha usado ```Transform.forward```, que nos da la dirección del eje z positivo del objeto, y se ha usado ```Transform.Rotate``` para rotar el objeto en el eje y dependiendo de los inputs del teclado, haciendo que el eje z positivo apunte hacia la dirección que queramos. Se ha necesitado tanto una velocidad para el movimiento como una velocidad para la rotación, ambas como atributos públicos. Además, se ha usado ```Debug.DrawRay``` para dibujar un rayo en la dirección del eje z positivo del objeto, para poder ver hacia dónde apunta este eje y que el funcionamiento del script fuera correcto.

Prueba de ejecución de este ejercicio:
![Gif Ejercicio 13](./gifs-readme2/ejercicio13.gif)