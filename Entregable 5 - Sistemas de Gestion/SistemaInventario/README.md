# Entregable 5 - Sistemas de Gestión

## Descripción

Este proyecto consiste en el desarrollo de un sistema de gestión de inventario utilizando el lenguaje C#. El programa fue desarrollado como una aplicación de consola para reforzar los conceptos de estructuras de datos, específicamente el uso de `struct`, arreglos y métodos.

El sistema permite registrar productos en un inventario, consultar la información almacenada y realizar operaciones básicas sobre los datos. Además, como parte del reto de extensión, se implementaron funciones adicionales para validar la entrada de datos, buscar productos por su identificador, actualizar el stock y almacenar la información en un archivo CSV para conservar los datos entre ejecuciones.

---

## Objetivos

- Comprender el uso de estructuras (`struct`) para representar entidades.
- Implementar arreglos como estructura de almacenamiento.
- Aplicar el paso de parámetros mediante `ref`.
- Desarrollar métodos para organizar la lógica del programa.
- Validar la entrada de datos utilizando `TryParse()`.
- Implementar persistencia de información mediante archivos CSV.

---

## Funcionalidades implementadas

### Práctica principal

- Registro de productos.
- Visualización del inventario completo.
- Uso de un arreglo de productos.
- Organización del programa mediante métodos.

### Retos de extensión

- Búsqueda de productos por ID.
- Validación de datos con `TryParse()`.
- Actualización del stock de un producto.
- Guardado y carga automática del inventario mediante un archivo CSV.

---

## Estructura del proyecto

```
SistemaInventario/
│
├── Program.cs
├── SistemaInventario.csproj
├── inventario.csv
├── bin/
└── obj/
```

---

## Tecnologías utilizadas

- C#
- .NET 10
- Visual Studio Code
- Git y GitHub

---

## Conceptos aplicados

- Struct
- Arreglos
- Métodos
- Parámetros por referencia (`ref`)
- Ciclos `for`
- Condicionales `if` y `switch`
- Validación de datos con `TryParse`
- Lectura y escritura de archivos (`File.ReadAllLines` y `File.WriteAllLines`)

---

## Cómo ejecutar el proyecto

1. Abrir la carpeta del proyecto en Visual Studio Code.
2. Abrir una terminal en la carpeta `SistemaInventario`.
3. Compilar el proyecto:

```bash
dotnet build
```

4. Ejecutar el programa:

```bash
dotnet run
```

---

## Autor

**Fernando Carrillo**

Materia: **Estructura de Datos**