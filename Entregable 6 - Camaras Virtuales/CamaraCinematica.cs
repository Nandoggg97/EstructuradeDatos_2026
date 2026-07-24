// ==================================================
// Estructuras de datos del rig de cámara cinemática
// ==================================================

struct Posicion
{
    public float x;
    public float y;
    public float z;
}

struct Foco
{
    public float x; // punto al que apunta la cámara
    public float y;
    public float z;
}

struct CamaraCinematica
{
    public string nombre;        // identificador del rig
    public Posicion pos;         // struct anidado: posición orbital
    public Foco foco;            // struct anidado: punto de interés
    public float fov;            // campo de visión en grados (ej: 60f)
    public float velocidad;      // factor de interpolación [0.01 – 1.0]
}