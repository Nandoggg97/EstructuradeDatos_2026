using FastCartBackendCore.Models;
using FastCartBackendCore.Services;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        const int cantidadProductos = 50;

        Producto[] catalogo = GenerarCatalogo(cantidadProductos);

        Console.WriteLine("==========================================");
        Console.WriteLine(" FASTCART BACKEND CORE - FASE 1");
        Console.WriteLine("==========================================");
        Console.WriteLine($"Total de productos: {catalogo.Length}");

        Console.WriteLine("\nCATÁLOGO ANTES DE ORDENAR");
        Console.WriteLine("-------------------------");
        MostrarPrimeros(catalogo, 5);

        Stopwatch cronometro = Stopwatch.StartNew();
        OrdenamientoService.ShellSort(catalogo);
        cronometro.Stop();

        Console.WriteLine("\nCATÁLOGO DESPUÉS DE ORDENAR");
        Console.WriteLine("---------------------------");
        MostrarPrimeros(catalogo, 5);

        Console.WriteLine();
        Console.WriteLine("RENDIMIENTO");
        Console.WriteLine("------------");
        Console.WriteLine($"Tiempo (ms): {cronometro.Elapsed.TotalMilliseconds:F4}");
        Console.WriteLine($"Tiempo (μs): {cronometro.Elapsed.TotalMilliseconds * 1000:F2}");
        Console.WriteLine($"Ticks: {cronometro.ElapsedTicks}");
    }

    static Producto[] GenerarCatalogo(int cantidad)
    {
        Producto[] catalogo = new Producto[cantidad];

        // Semilla fija para obtener los mismos datos en cada ejecución
        Random random = new Random(2026);

        string[] nombresProductos =
        {
            "Laptop",
            "Monitor",
            "Teclado",
            "Mouse",
            "Impresora",
            "Disco SSD",
            "Memoria RAM",
            "Audífonos",
            "Webcam",
            "Router"
        };

        string[] nombresProveedores =
        {
            "Tecnología del Centro",
            "Periféricos MX",
            "Oficina Express",
            "Distribuidora Digital",
            "Soluciones FastCart"
        };

        for (int i = 0; i < cantidad; i++)
        {
            int indiceProducto = random.Next(nombresProductos.Length);
            int indiceProveedor = random.Next(nombresProveedores.Length);

            catalogo[i] = new Producto
            {
                SKU = 1001 + i,
                Nombre = $"{nombresProductos[indiceProducto]} {i + 1}",
                Precio = Math.Round(
                    random.NextDouble() * (9999.99 - 10.00) + 10.00,
                    2),
                Stock = random.Next(0, 501),

                DatosProveedor = new Proveedor
                {
                    IdProveedor = indiceProveedor + 1,
                    NombreCorporativo = nombresProveedores[indiceProveedor]
                }
            };
        }

        // Tres precios idénticos para probar el desempate por SKU
        if (cantidad >= 3)
        {
            catalogo[0].Precio = 7500.00;
            catalogo[1].Precio = 7500.00;
            catalogo[2].Precio = 7500.00;
        }

        return catalogo;
    }

    static void MostrarPrimeros(Producto[] catalogo, int cantidad)
    {
        int limite = Math.Min(cantidad, catalogo.Length);

        for (int i = 0; i < limite; i++)
        {
            Producto producto = catalogo[i];

            Console.WriteLine(
                $"{producto.SKU} | " +
                $"{producto.Nombre,-18} | " +
                $"${producto.Precio,8:F2} | " +
                $"Stock: {producto.Stock,3} | " +
                $"{producto.DatosProveedor.NombreCorporativo}");
        }
    }
}