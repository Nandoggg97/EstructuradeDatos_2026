using System;
using System.Diagnostics;
using Semana4Recursividad;

int nFactorial = 20;
int nFibonacci = 40;

var sw = new Stopwatch();

Console.WriteLine("==============================================");
Console.WriteLine("     COMPARATIVA: ITERATIVO VS RECURSIVO");
Console.WriteLine("==============================================");

// FACTORIAL ITERATIVO
Console.WriteLine($"\n--- FACTORIAL({nFactorial}) ---");

sw.Restart();
long resultadoFactorialIterativo =
    AlgoritmosIterativos.FactorialIterativo(nFactorial);
sw.Stop();

Console.WriteLine(
    $"[Iterativo] Resultado: {resultadoFactorialIterativo,25} " +
    $"Tiempo: {sw.Elapsed.TotalMilliseconds:F6} ms"
);

// FACTORIAL RECURSIVO
sw.Restart();
long resultadoFactorialRecursivo =
    AlgoritmosRecursivos.FactorialRecursivo(nFactorial);
sw.Stop();

Console.WriteLine(
    $"[Recursivo] Resultado: {resultadoFactorialRecursivo,25} " +
    $"Tiempo: {sw.Elapsed.TotalMilliseconds:F6} ms"
);

// FIBONACCI ITERATIVO
Console.WriteLine($"\n--- FIBONACCI({nFibonacci}) ---");

sw.Restart();
long resultadoFibonacciIterativo =
    AlgoritmosIterativos.FibonacciIterativo(nFibonacci);
sw.Stop();

Console.WriteLine(
    $"[Iterativo] Resultado: {resultadoFibonacciIterativo,25} " +
    $"Tiempo: {sw.Elapsed.TotalMilliseconds:F6} ms"
);

// FIBONACCI RECURSIVO
sw.Restart();
long resultadoFibonacciRecursivo =
    AlgoritmosRecursivos.FibonacciRecursivo(nFibonacci);
sw.Stop();

Console.WriteLine(
    $"[Recursivo] Resultado: {resultadoFibonacciRecursivo,25} " +
    $"Tiempo: {sw.Elapsed.TotalMilliseconds:F6} ms"
);

Console.WriteLine(
    "\n[OK] Prueba completada. Registra los tiempos en tu bitacora."
);