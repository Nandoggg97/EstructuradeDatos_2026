namespace CalculadoraFisica;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding =
        System.Text.Encoding.UTF8;
        bool continuar = true;

        while (continuar)
        {
            MostrarMenu();
            string opcion =
            Console.ReadLine() ?? "0";
            continuar =
            ProcesarOpcion(opcion);
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine(
            " ____________________________________________________________");
        Console.WriteLine(
            "|  CALCULADORA DE CINEMÁTICA                                |");
        Console.WriteLine(
            " ____________________________________________________________");
        Console.WriteLine(
            "|  1. Calcular velocidad                                    |");
        Console.WriteLine(
            "|  2. Calcular distancia                                    |");    
        Console.WriteLine(
            "|  3. Calcular tiempo                                       |");
        Console.WriteLine(
            "|  0. Salir                                    |");
        Console.WriteLine(
            " ____________________________________________________________");
        Console.Write("\n Elige una opcion:");
    }

    static bool ProcesarOpcion(string opcion)
    {
        Console.WriteLine();
        switch (opcion.Trim())
        {
            case "1":
            double d1 = EntradaUsuario.PedirDouble(
                " Distancia (m): ");
            double t1 = EntradaUsuario.PedirDouble(
                " Tiempo (s): ");
            double v = Calculos.CalcularVelocidad(d1, t1);
            Console.WriteLine(
                $"\nVelocidad = {v:F2} m/s");
            break;

             case "2":
            double v2 = EntradaUsuario.PedirDouble(
                "Velocidad (m/s): ");
            double t2 = EntradaUsuario.PedirDouble("Tiempo (s): ");
            double d = Calculos.CalcularDistancia(v2, t2);
            Console.WriteLine(
                $"\nDistancia = {d:F2} m");
            break;

            case "3":
            double d3 = EntradaUsuario.PedirDouble("Distancia (m): ");
            double v3 = EntradaUsuario.PedirDouble("Velocidad (m/s): ");
            double t = Calculos.CalcularTiempo(d3, v3);
            Console.WriteLine(
                $"\nTiempo = {t:F2} s");
            break;

        case "0":
            return false;
        default:
            Console.WriteLine("Opción no válida.");
            break;
        }
        Console.WriteLine(
            "\nPresiona una tecla para continuar...");
        Console.ReadKey();
        return true;
    }
}