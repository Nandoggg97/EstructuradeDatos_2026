using FastCartBackendCore.Models;

namespace FastCartBackendCore.Services;

public static class OrdenamientoService
{
    public static void ShellSort(Producto[] catalogo)
    {
        int n = catalogo.Length;

        // Calcular gap inicial con secuencia de Knuth
        int gap = 1;

        while (gap < n / 3)
        {
            gap = gap * 3 + 1;
        }

        while (gap >= 1)
        {
            // Insertion Sort con la brecha actual
            for (int i = gap; i < n; i++)
            {
                Producto temp = catalogo[i];
                int j = i;

                // Comparar: Precio DESC, SKU ASC como desempate
                while (j >= gap && EsMayor(catalogo[j - gap], temp))
                {
                    catalogo[j] = catalogo[j - gap];
                    j -= gap;
                }

                catalogo[j] = temp;
            }

            gap = gap / 3;
        }
    }

    // A debe ir después de B si tiene menor precio,
    // o si tienen el mismo precio y su SKU es mayor.
    private static bool EsMayor(Producto a, Producto b)
    {
        if (a.Precio != b.Precio)
        {
            return a.Precio < b.Precio;
        }

        return a.SKU > b.SKU;
    }
}