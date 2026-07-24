# Entregable 6 - Cámaras Virtuales mediante Estructuras Anidadas

## Nombre

Fernando Carrillo Rodriguez

## Matrícula

333007334

## Descripción

Este proyecto consiste en el desarrollo de una simulación de una cámara cinemática utilizando estructuras anidadas (`struct`) en C#. El programa fue desarrollado como una aplicación de consola para reforzar el uso de estructuras de datos, el paso de parámetros por referencia (`ref`) y la composición de estructuras.

Como parte del reto de extensión, se implementó un segundo rig de cámara y una función de corte que permite cambiar instantáneamente entre cámaras virtuales, simulando un cambio de plano similar al utilizado en motores de videojuegos y producción cinematográfica.

## Tecnologías utilizadas

- C#
- .NET
- Visual Studio Code
- Git
- GitHub

## Funcionalidades implementadas

- Definición de estructuras `Posicion`, `Foco` y `CamaraCinematica`.
- Uso de estructuras anidadas para organizar la información de la cámara.
- Inicialización de una cámara principal.
- Actualización de la cámara mediante interpolación lineal (Lerp).
- Paso de estructuras por referencia utilizando `ref`.
- Simulación del movimiento de la cámara durante 20 frames.
- Visualización del estado de la cámara en cada iteración.
- Implementación de un segundo rig de cámara.
- Función de corte entre cámaras virtuales.

## Valores de prueba

Se realizaron pruebas utilizando la siguiente configuración inicial:

- Cámara principal: `CAM_PRINCIPAL`
- Campo de visión (FOV): 60°
- Velocidad de interpolación: 0.08
- Posición inicial: (10, 5, -8)
- Posición objetivo: (0, 2, -5)
- Foco inicial: (0, 0, 0)
- Foco objetivo: (0, 1, 0)

También se verificó:

- Movimiento progresivo de la cámara hacia el objetivo.
- Actualización correcta de la posición y del foco.
- Impresión de los 20 frames en consola.
- Cambio instantáneo al segundo rig mediante la función de corte.

## Resultados obtenidos

```text
Rig 'CAM_PRINCIPAL' creado. FOV=60°

=== Simulación de 20 frames ===

[Frame 001] CAM_PRINCIPAL ...
...
[Frame 020] CAM_PRINCIPAL ...

¡Simulación completada!

Corte realizado hacia 'CAM_CLOSEUP'.

Estado después del corte:
[Frame 021] CAM_PRINCIPAL | POS(1.00, 1.80, -1.50) | FOCO(0.00, 1.70, 0.00)
```

Durante las pruebas se comprobó que la cámara se aproxima gradualmente a la posición objetivo utilizando interpolación lineal y que la función de corte copia correctamente la información del segundo rig hacia la cámara principal.

## Ejecutar el proyecto

Abrir una terminal dentro de la carpeta del proyecto y ejecutar:

```bash
dotnet run
```

## Conclusión

Esta práctica permitió reforzar el uso de estructuras de datos mediante la composición de estructuras (`struct` anidados), organizando la información de una forma más clara y reutilizable. También permitió comprender la importancia del paso por referencia (`ref`) para modificar estructuras sin realizar copias innecesarias y aplicar la interpolación lineal para simular movimientos suaves, una técnica ampliamente utilizada en motores de videojuegos y aplicaciones gráficas. Finalmente, la implementación del segundo rig y la función de corte mostró cómo es posible administrar diferentes cámaras virtuales y cambiar entre ellas de manera eficiente.