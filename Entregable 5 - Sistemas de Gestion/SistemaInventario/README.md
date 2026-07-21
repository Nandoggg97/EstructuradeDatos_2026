# Entregable 5 - Sistemas de Gestión

## Nombre

Fernando Carrillo Rodriguez

## Matrícula

333007334

## Descripción

Este proyecto consiste en el desarrollo de un sistema de gestión de inventario utilizando el lenguaje C#. El programa fue desarrollado como una aplicación de consola para reforzar el uso de estructuras de datos, específicamente el uso de `struct`, arreglos y métodos.

Como parte del reto de extensión, se implementaron funciones adicionales para validar la entrada de datos, buscar productos por su identificador, actualizar el stock y almacenar la información en un archivo CSV para conservar los datos entre ejecuciones.

## Tecnologías utilizadas

- C#
- .NET
- Visual Studio Code
- Git
- GitHub

## Funcionalidades implementadas

- Registro de productos mediante `struct`.
- Almacenamiento de productos en un arreglo.
- Listado completo del inventario.
- Búsqueda de productos por ID.
- Actualización del stock de un producto.
- Validación de entradas numéricas utilizando `TryParse`.
- Guardado automático del inventario en un archivo CSV.
- Carga automática del inventario al iniciar el programa.

## Valores de prueba

Se realizaron pruebas registrando productos como:

- ID: 101 — Laptop HP — $899.99 — Stock: 25
- ID: 102 — Mouse Inalámbrico — $24.50 — Stock: 80

También se verificó:

- Búsqueda de productos existentes.
- Búsqueda de productos inexistentes.
- Actualización del stock.
- Validación de entradas inválidas.
- Persistencia de datos después de cerrar y volver a ejecutar el programa.

## Resultados obtenidos

```text
SISTEMA DE INVENTARIO

1. Registrar producto
2. Mostrar todos los productos
3. Buscar producto por ID
4. Actualizar stock
5. Salir

El sistema permite registrar productos, consultarlos,
buscar por identificador, actualizar existencias y
guardar automáticamente la información en un archivo CSV.
```

Durante las pruebas se comprobó que la información permanece disponible incluso después de cerrar el programa gracias a la lectura y escritura del archivo `inventario.csv`.

## Ejecutar el proyecto

Abrir una terminal dentro de la carpeta del proyecto y ejecutar:

```bash
dotnet run
```

## Conclusión

Esta práctica permitió aplicar estructuras de datos mediante el uso de `struct` y arreglos para administrar información de manera organizada. Además, el reto de extensión permitió incorporar validación de datos, búsqueda, actualización y persistencia mediante archivos CSV, acercando el proyecto a un sistema de inventario más completo y funcional. También reforzó el uso de métodos, ciclos y buenas prácticas para desarrollar aplicaciones de consola en C#.