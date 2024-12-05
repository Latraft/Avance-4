using System;

namespace OrdenamientoShellsort
{
    public static class Ordenador
    {
        public static void Shellsort(int[] lista)
        {
            int n = lista.Length;

            for (int intervalo = n / 2; intervalo > 0; intervalo /= 2)
            {
           
                for (int i = intervalo; i < n; i++)
                {
                    int temp = lista[i];
                    int j;

            
                    for (j = i; j >= intervalo && lista[j - intervalo] > temp; j -= intervalo)
                    {
                        lista[j] = lista[j - intervalo];
                    }

                    lista[j] = temp;
                }
            }
        }
    }
}