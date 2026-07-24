# Proyecto Final - Fase 1 - FastCart Backend Core

## Nombre

Fernando Carrillo Rodriguez

## Matrícula

333007334

## Descripción

Este proyecto corresponde a la primera fase del proyecto final de la materia Estructura de Datos. Consiste en el desarrollo de un núcleo de procesamiento en C# para administrar y ordenar un catálogo de productos de una empresa de comercio electrónico y logística.

El sistema utiliza estructuras anidadas (`struct`) para representar productos y proveedores. También implementa de forma nativa el algoritmo ShellSort, sin utilizar LINQ, `Array.Sort()` ni `.Sort()`. El catálogo se ordena primero por precio descendente y, cuando existen productos con el mismo precio, por SKU ascendente.

Además, se utiliza la clase `Stopwatch` para medir el rendimiento del algoritmo y mostrar el tiempo de ejecución en milisegundos, microsegundos y ticks.

## Tecnologías utilizadas

- C#
- .NET
- Visual Studio Code
- Git
- GitHub

## Estructura del proyecto

- `Models/Proveedor.cs`
  - Contiene la estructura `Proveedor`.
- `Models/Producto.cs`
  - Contiene la estructura `Producto` y la composición con `Proveedor`.
- `Services/OrdenamientoService.cs`
  - Contiene la implementación nativa del algoritmo ShellSort.
- `Program.cs`
  - Genera el catálogo, muestra los productos y mide el rendimiento.

## Funcionalidades implementadas

- Definición de la estructura `Proveedor`.
- Definición de la estructura compuesta `Producto`.
- Generación automática de 50 productos.
- Creación de SKU únicos a partir del número 1001.
- Generación de precios entre $10.00 y $9,999.99.
- Generación de stock entre 0 y 500.
- Generación reproducible de datos mediante una semilla fija.
- Inclusión de productos con precios idénticos para comprobar el desempate.
- Implementación nativa e iterativa de ShellSort.
- Uso de la secuencia de brechas de Knuth.
- Ordenamiento por precio descendente.
- Desempate por SKU ascendente.
- Medición de rendimiento con `Stopwatch`.
- Visualización de los primeros cinco productos antes y después del ordenamiento.

## Valores de prueba

El programa genera un lote de 50 productos simulados con las siguientes condiciones:

- SKU desde 1001 hasta 1050.
- Precio mínimo de $10.00.
- Precio máximo de $9,999.99.
- Stock entre 0 y 500 unidades.
- Tres productos con precio de $7,500.00 para validar el desempate por SKU.
- Semilla fija `2026` para obtener resultados reproducibles.

## Resultados obtenidos

```text
FASTCART BACKEND CORE - FASE 1

Total de productos: 50

CATÁLOGO ANTES DE ORDENAR
-------------------------
1001 | Monitor 1       | $7500.00 | Stock: 497
1002 | Router 2        | $7500.00 | Stock: 428
1003 | Memoria RAM 3   | $7500.00 | Stock: 97

CATÁLOGO DESPUÉS DE ORDENAR
---------------------------
1021 | Router 21       | $9391.27 | Stock: 79
1030 | Audífonos 30    | $9378.35 | Stock: 460
1019 | Webcam 19       | $9346.33 | Stock: 213

RENDIMIENTO
-----------
Tiempo (ms): 0.2841
Tiempo (µs): 284.10
Ticks: 2841
```

Los tiempos pueden cambiar según el equipo y las condiciones de ejecución. Durante las pruebas se comprobó que el catálogo queda ordenado correctamente por precio descendente y que los productos con el mismo precio se ordenan por SKU ascendente.

## Ejecutar el proyecto

Abrir una terminal dentro de la carpeta del proyecto y ejecutar:

```bash
dotnet run
```

Para realizar la prueba de rendimiento en modo Release:

```bash
dotnet run -c Release
```

## Conclusión

Esta primera fase permitió establecer la base técnica del sistema FastCart mediante el uso de estructuras anidadas para representar productos y proveedores de forma organizada. También permitió implementar desde cero el algoritmo ShellSort, comprendiendo el funcionamiento de las brechas, las comparaciones y los desplazamientos internos del arreglo.

La medición con `Stopwatch` permitió comprobar de manera práctica el rendimiento del algoritmo y comparar la ejecución mediante milisegundos, microsegundos y ticks. Esta estructura modular facilitará la incorporación de nuevas funcionalidades durante las siguientes fases del proyecto final.