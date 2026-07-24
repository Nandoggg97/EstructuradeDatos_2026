using FastCartBackendCore.Models;

Console.WriteLine("===================================");
Console.WriteLine(" FastCart Backend Core - Fase 1");
Console.WriteLine("===================================");

Proveedor proveedor = new Proveedor
    {
        IdProveedor = 1,
        NombreCorporativo = "FastCart México"
    };

    Producto producto = new Producto
    {
        SKU = 1001,
        Nombre = "Laptop HP",
        Precio = 18999.99,
        Stock = 15,
        DatosProveedor = proveedor
    };

Console.WriteLine();
Console.WriteLine("Producto de prueba");
Console.WriteLine("------------------");
Console.WriteLine($"SKU: {producto.SKU}");
Console.WriteLine($"Nombre: {producto.Nombre}");
Console.WriteLine($"Precio: ${producto.Precio}");
Console.WriteLine($"Stock: {producto.Stock}");
Console.WriteLine($"Proveedor: {producto.DatosProveedor.NombreCorporativo}");