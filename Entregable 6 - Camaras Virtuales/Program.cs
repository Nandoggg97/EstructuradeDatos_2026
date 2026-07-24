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

        // Continúa en los siguientes pasos...
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
}