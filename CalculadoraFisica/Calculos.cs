namespace CalculadoraFisica;

/// <summary>
/// Módulo de cálculos físicos de cinemática.
/// Todas las funciones son puras: mismo input = mismo output.
/// </summary>
static class Calculos
{
    ///<summary>Calcula velocidad: v = d / t</summary>
    /// <param name="distanciaMetros">Distancia en metros</param>
    /// <param name="tiempoSegundos">Tiempo en segundos (> 0)</param>
    /// <returns>Velocidad en metros por segundo</returns>
    public static void CalcularVelocidad(
        double distanciaMetros,
        double tiempoSegundos,
        ref double velocidad)
    {
        velocidad = distanciaMetros / tiempoSegundos;
    }
    
/// <summary>Calcula distancia: d = v * t</summary>
public static void CalcularDistancia(
    double velocidadMS,
    double tiempoSegundos,
    ref double distancia)
    {
        distancia = velocidadMS * tiempoSegundos;
    }

/// <summary>Calcula tiempo: t = d / v</summary>
public static void CalcularTiempo(
    double distanciaMetros,
    double velocidadMS,
    out double tiempo)
    {
        tiempo = distanciaMetros / velocidadMS;
    }
}