using System;

class Program
{
    static void Main(string[] args)
    {
        // Creación e inicialización del rig
        CamaraCinematica camara;
        camara.nombre = "CAM_PRINCIPAL";
        camara.fov = 60f;
        camara.velocidad = 0.08f; // 8 % de interpolación por frame

        // Posición inicial: elevada y desplazada a la derecha
        camara.pos.x = 10f;
        camara.pos.y = 5f;
        camara.pos.z = -8f;

        // Foco inicial: origen de la escena
        camara.foco.x = 0f;
        camara.foco.y = 0f;
        camara.foco.z = 0f;

        Console.WriteLine($"Rig '{camara.nombre}' creado. FOV={camara.fov}°");

        Posicion posTarget;
        posTarget.x = 0f;
        posTarget.y = 2f;
        posTarget.z = -5f;

        Foco focoTarget;
        focoTarget.x = 0f;
        focoTarget.y = 1f;
        focoTarget.z = 0f;

        Console.WriteLine("\n=== Simulación de 20 frames ===\n");

        for (int frame = 1; frame <= 20; frame++)
        {
            ActualizarCamara(ref camara, posTarget, focoTarget);
            ImprimirEstado(camara, frame);

            System.Threading.Thread.Sleep(80);
        }

        Console.WriteLine("\n¡Simulación completada!");

        // Segundo rig: cámara de plano cercano
        CamaraCinematica camCloseUp;

        camCloseUp.nombre = "CAM_CLOSEUP";
        camCloseUp.fov = 35f;
        camCloseUp.velocidad = 0.15f;

        camCloseUp.pos.x = 1f;
        camCloseUp.pos.y = 1.8f;
        camCloseUp.pos.z = -1.5f;

        camCloseUp.foco.x = 0f;
        camCloseUp.foco.y = 1.7f;
        camCloseUp.foco.z = 0f;

        CortarA(ref camara, camCloseUp);

        Console.WriteLine("\nEstado después del corte:");

        ImprimirEstado(camara, 21);
    }


    static void ActualizarCamara(
    ref CamaraCinematica cam,
    Posicion posObjetivo,
    Foco focoObjetivo)
    {
        float a = cam.velocidad;

        // Interpolación de posición
        cam.pos.x += (posObjetivo.x - cam.pos.x) * a;
        cam.pos.y += (posObjetivo.y - cam.pos.y) * a;
        cam.pos.z += (posObjetivo.z - cam.pos.z) * a;

        // Interpolación de foco
        cam.foco.x += (focoObjetivo.x - cam.foco.x) * a;
        cam.foco.y += (focoObjetivo.y - cam.foco.y) * a;
        cam.foco.z += (focoObjetivo.z - cam.foco.z) * a;
    }


    static void ImprimirEstado(CamaraCinematica cam, int frame)
    {
        Console.WriteLine(
            $"[Frame {frame:D3}] {cam.nombre} | " +
            $"POS({cam.pos.x:F2}, {cam.pos.y:F2}, {cam.pos.z:F2}) | " +
            $"FOCO({cam.foco.x:F2}, {cam.foco.y:F2}, {cam.foco.z:F2})");
    }


    static void CortarA(ref CamaraCinematica destino,
                    CamaraCinematica fuente)
    {
        destino.pos.x = fuente.pos.x;
        destino.pos.y = fuente.pos.y;
        destino.pos.z = fuente.pos.z;

        destino.foco.x = fuente.foco.x;
        destino.foco.y = fuente.foco.y;
        destino.foco.z = fuente.foco.z;

        destino.fov = fuente.fov;

        Console.WriteLine($"\nCorte realizado hacia '{fuente.nombre}'.");
    }
}