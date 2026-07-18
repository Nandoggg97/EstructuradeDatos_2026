# Entregable 4 - Recursividad Segura en C#

## Nombre

Fernando Carrillo Rodriguez

## Matricula

333007334

## Descripcion

Este proyecto compara las implementaciones iterativas y recursivas de los algoritmos Factorial y Fibonacci en C#. También utiliza System.Diagnostics.Stopwatch para medir el tiempo de ejecución de cada método y comprobar las diferencias de rendimiento.

## Tecnologias utilizadas

- C#
- .NET
- Visual Studio Code
- Git
- GitHub

## Algoritmos implementados

- Factorial iterativo
- Factorial recursivo con caso base
- Fibonacci iterativo
- Fibonacci recursivo con casos base

## Valores de prueba

- Factorial: n = 20
- Fibonacci: n = 40

## Resultados obtenidos

```text
FACTORIAL(20)

Iterativo:
Resultado: 2432902008176640000

Recursivo:
Resultado: 2432902008176640000

FIBONACCI(40)

Iterativo:
Resultado: 102334155
Tiempo aproximado observado: 0.109400 ms

Recursivo:
Resultado: 102334155
Tiempo aproximado observado: 1373.585900 ms
```

Los tiempos pueden cambiar entre ejecuciones y computadoras. Sin embargo, se observa que Fibonacci recursivo tarda considerablemente más que la versión iterativa debido a que repite una gran cantidad de cálculos.

## Ejecutar el proyecto

Abrir una terminal dentro de la carpeta del proyecto y ejecutar:

```bash
dotnet run
```

## Conclusion

La práctica permitió comprobar que la recursividad puede producir soluciones claras y fáciles de comprender, siempre que exista un caso base que detenga correctamente las llamadas. Sin embargo, también se observó que una solución recursiva puede tener un costo de rendimiento muy alto, como ocurre con Fibonacci. Por ello, es necesario analizar cada problema antes de decidir entre una implementación iterativa o recursiva.