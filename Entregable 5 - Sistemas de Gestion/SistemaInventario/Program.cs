namespace SistemaInventario
{
    /// <summary>
    /// Representa un producto dentro del inventario de la empresa.
    /// Se usa struct porque es un registro de datos pequeño y tipo de valor.
    /// </summary>
    struct Producto
    {
        public int ID;          //Identificador unico del producto
        public string Nombre;   //Nombre descriptivo del articulo
        public double Precio;      //Precio unitario en moneda local
        public int Stock;       //Cantidad disponible en almacen
    }

    class Program
    {
        const string ARCHIVO_INVENTARIO = "inventario.csv";

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Sistema de Gestión de Inventario v1.0";

            const int CAPACIDAD = 10;
            Producto[] inventario = new Producto[CAPACIDAD];
            int totalRegistros = 0;

            CargarInventario(inventario, ref totalRegistros);
            
            string opcion = "";
            do
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════════╗");
                Console.WriteLine("║      SISTEMA DE INVENTARIO - MENÚ    ║");
                Console.WriteLine("╠══════════════════════════════════════╣");
                Console.WriteLine("║ 1. Registrar producto                ║");
                Console.WriteLine("║ 2. Mostrar todos los productos       ║");
                Console.WriteLine("║ 3. Buscar producto por ID            ║");
                Console.WriteLine("║ 4. Actualizar stock                  ║");
                Console.WriteLine("║ 5. Salir                             ║");
                Console.WriteLine("╚══════════════════════════════════════╝");
                Console.Write("\nSelecciona una opción: ");
                opcion = Console.ReadLine() ?? "";

                switch (opcion)
                {
                    case "1":
                    RegistrarProducto(inventario, ref totalRegistros, CAPACIDAD);
                    break;

                    case "2":
                    MostrarProductos(inventario, totalRegistros);
                    break;

                    case "3":
                    BuscarProductoPorID(inventario, totalRegistros);
                    break;

                     case "4":
                    ActualizarStock(inventario, totalRegistros);
                    break;

                    case "5":
                    GuardarInventario(inventario, totalRegistros);
                    Console.WriteLine("\nInventario guardado correctamente.");
                    Console.WriteLine("Cerrando el sistema... ¡Hasta pronto!");
                    break;

                    default:
                    Console.WriteLine("\nOpción inválida. Presiona Enter para continuar.");
                    Console.ReadLine();
                    break;
                }
            }while (opcion != "5");
        }
            static void RegistrarProducto(Producto[] inventario, ref int total, int capacidad)
            {
                Console.Clear();
                Console.WriteLine("── REGISTRAR NUEVO PRODUCTO ──\n");

                // ── Validación de capacidad ───────────────────────────────────
                if (total >= capacidad)
                {
                    Console.WriteLine(" [!] El inventario está lleno. No se pueden agregar más productos.");
                    Console.ReadLine();
                    return;
                }

                // ── Captura de datos del usuario ──────────────────────────────
                inventario[total].ID = LeerEntero(" ID del producto : ");
                Console.Write(" Nombre : ");
                inventario[total].Nombre = Console.ReadLine()?.Trim() ?? "";

                inventario[total].Precio = LeerDouble(" Precio unitario : $");

                inventario[total].Stock = LeerEntero(" Stock disponible : ");

                // ── Incrementar el contador ───────────────────────────────────
                total++;

                Console.WriteLine($"\n [✓] Producto registrado exitosamente. Total en inventario: {total}");
                Console.ReadLine();
            }

            static void MostrarProductos(Producto[] inventario, int total)
            {
                Console.Clear();
                Console.WriteLine("── LISTADO COMPLETO DE INVENTARIO ──\n");

                // ── Verificar si hay productos registrados ────────────────────
                if (total == 0)
                {
                    Console.WriteLine(" [!] No hay productos registrados aún.");
                    Console.ReadLine();
                    return;
                }

                // ── Encabezado de tabla ───────────────────────────────────────
                Console.WriteLine($" {"ID",-6} {"Nombre",-20} {"Precio",10} {"Stock",8}");
                Console.WriteLine($" {new string('-', 48)}");

                // ── Ciclo de recorrido del arreglo ────────────────────────────
                for (int i = 0; i < total; i++)
                {
                    Console.WriteLine(
                        $" {inventario[i].ID,-6} " +
                        $"{inventario[i].Nombre,-20} " +
                        $"${inventario[i].Precio,9:F2} " +
                        $"{inventario[i].Stock,8}"
                    );
                }

                Console.WriteLine($"\n Total de productos: {total}");
                Console.ReadLine();
            }

            static void BuscarProductoPorID(Producto[] inventario, int total)
            {
                Console.Clear();
                Console.WriteLine("── BUSCAR PRODUCTO POR ID ──\n");

                if (total == 0)
                {
                    Console.WriteLine(" [!] No hay productos registrados aún.");
                    Console.ReadLine();
                    return;
                }

                int idBuscado = LeerEntero(" Ingresa el ID del producto: ");

                bool encontrado = false;

                for (int i = 0; i < total; i++)
                {
                    if (inventario[i].ID == idBuscado)
                    {
                        Console.WriteLine("\n [✓] Producto encontrado:");
                        Console.WriteLine($" ID     : {inventario[i].ID}");
                        Console.WriteLine($" Nombre : {inventario[i].Nombre}");
                        Console.WriteLine($" Precio : ${inventario[i].Precio:F2}");
                        Console.WriteLine($" Stock  : {inventario[i].Stock}");

                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("\n [!] No se encontró un producto con ese ID.");
                }

                Console.ReadLine();
            }

            static int LeerEntero(string mensaje)
            {
                int valor;

                while (true)
                {
                    Console.Write(mensaje);

                    if (int.TryParse(Console.ReadLine(), out valor))
                    {
                        return valor;
                    }

                    Console.WriteLine(" [!] Entrada inválida. Debes ingresar un número entero.");
                }
            }

            static double LeerDouble(string mensaje)
            {
                double valor;

                while (true)
                {
                    Console.Write(mensaje);

                    if (double.TryParse(Console.ReadLine(), out valor))
                    {
                        return valor;
                    }

                    Console.WriteLine(" [!] Entrada inválida. Debes ingresar un número válido.");
                }
            }

            static void ActualizarStock(Producto[] inventario, int total)
        {
            Console.Clear();
            Console.WriteLine("── ACTUALIZAR STOCK ──\n");

            if (total == 0)
            {
                Console.WriteLine(" [!] No hay productos registrados aún.");
                Console.ReadLine();
                return;
            }

            int idBuscado = LeerEntero(" Ingresa el ID del producto: ");

            for (int i = 0; i < total; i++)
            {
                if (inventario[i].ID == idBuscado)
                {
                    Console.WriteLine("\n Producto encontrado:");
                    Console.WriteLine($" Nombre actual : {inventario[i].Nombre}");
                    Console.WriteLine($" Stock actual  : {inventario[i].Stock}");

                    int nuevoStock = LeerEntero("\n Ingresa el nuevo stock: ");

                    inventario[i].Stock = nuevoStock;

                    Console.WriteLine("\n [✓] Stock actualizado correctamente.");
                    Console.WriteLine($" Nuevo stock: {inventario[i].Stock}");
                    Console.ReadLine();
                    return;
                }
            }

            Console.WriteLine("\n [!] No se encontró un producto con ese ID.");
            Console.ReadLine();
        }

        static void GuardarInventario(Producto[] inventario, int total)
        {
            string[] lineas = new string[total];

            for (int i = 0; i < total; i++)
            {
                lineas[i] =
                    $"{inventario[i].ID}," +
                    $"{inventario[i].Nombre}," +
                    $"{inventario[i].Precio}," +
                    $"{inventario[i].Stock}";
            }

            File.WriteAllLines(ARCHIVO_INVENTARIO, lineas);
        }

        static void CargarInventario(Producto[] inventario, ref int total)
        {
            if (!File.Exists(ARCHIVO_INVENTARIO))
            {
                return;
            }

            string[] lineas = File.ReadAllLines(ARCHIVO_INVENTARIO);

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');

                inventario[total].ID = int.Parse(datos[0]);
                inventario[total].Nombre = datos[1];
                inventario[total].Precio = double.Parse(datos[2]);
                inventario[total].Stock = int.Parse(datos[3]);

                total++;
            }
        }
    }
}

