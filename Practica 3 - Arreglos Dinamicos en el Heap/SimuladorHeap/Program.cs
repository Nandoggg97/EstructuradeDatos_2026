using System;

class SimuladorHeap
{
    // Main: punto de entrada del programa
    static void Main(string[] args)
    {
        Console.Write("¿Cuantos elementos? ");
        int n = int.Parse(Console.ReadLine()!);

        // Creamos un arreglo dinamico
        string[] arreglo = InicializarArreglo(n);

        Console.WriteLine("\n--- Arreglo Inicial ---");
        MostrarArreglo(arreglo);

        ModificarArreglo(arreglo);

        Console.WriteLine("\n--- Arreglo Modificado ---");
        MostrarArreglo(arreglo);
    }

    static string[] InicializarArreglo(int n)
    {
        string[] temp = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elemento [{i}]: ");
            temp[i] = Console.ReadLine()!;
        }
        
        return temp;
    }

    static void ModificarArreglo(string[] arr)
    {
       for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = arr[i].ToUpper() + $" [MOD--{i}]";
        } 
    }

    static void MostrarArreglo(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"[{i}] = {arr[i]}");
        }
    }
}