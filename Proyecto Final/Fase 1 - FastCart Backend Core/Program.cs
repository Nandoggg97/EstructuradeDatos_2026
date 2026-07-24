using FastCartBackendCore.Models;
using FastCartBackendCore.Services;

Producto[] catalogo = new Producto[5];

catalogo[0] = new Producto
    {
        SKU = 1003,
        Nombre = "Monitor",
        Precio = 500.00,
        Stock = 20,
        DatosProveedor = new Proveedor
        {
            IdProveedor = 1,
            NombreCorporativo = "Tecnología del Centro"
        }
    };

catalogo[1] = new Producto
    {
        SKU = 1001,
        Nombre = "Teclado",
        Precio = 200.00,
        Stock = 35,
        DatosProveedor = new Proveedor
        {
            IdProveedor = 2,
            NombreCorporativo = "Periféricos MX"
        }
    };

catalogo[2] = new Producto
    {
        SKU = 1007,
        Nombre = "Laptop",
        Precio = 500.00,
        Stock = 10,
        DatosProveedor = new Proveedor
        {
            IdProveedor = 1,
            NombreCorporativo = "Tecnología del Centro"
        }
    };

catalogo[3] = new Producto
    {
        SKU = 1002,
        Nombre = "Mouse",
        Precio = 100.00,
        Stock = 50,
        DatosProveedor = new Proveedor
        {
            IdProveedor = 2,
            NombreCorporativo = "Periféricos MX"
        }
    };

catalogo[4] = new Producto
    {
        SKU = 1005,
        Nombre = "Impresora",
        Precio = 300.00,
        Stock = 12,
        DatosProveedor = new Proveedor
        {
            IdProveedor = 3,
            NombreCorporativo = "Oficina Express"
        }
    };

Console.WriteLine("CATÁLOGO ANTES DE ORDENAR");
Console.WriteLine("-------------------------");
MostrarCatalogo(catalogo);

OrdenamientoService.ShellSort(catalogo);

Console.WriteLine();
Console.WriteLine("CATÁLOGO DESPUÉS DE ORDENAR");
Console.WriteLine("---------------------------");
MostrarCatalogo(catalogo);


void MostrarCatalogo(Producto[] catalogo)
    {
        foreach (Producto producto in catalogo)
        {
            Console.WriteLine(
                $"{producto.SKU} | " +
                $"{producto.Nombre} | " +
                $"${producto.Precio:F2} | " +
                $"Stock: {producto.Stock}");
        }
    }