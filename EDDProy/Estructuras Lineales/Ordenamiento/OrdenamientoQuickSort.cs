using System;

namespace OrdenamientoQuickSort
{
    public static class Ordenado
    {

        public static void QuickSort(int[] lista)
        {
            QuickSort(lista, 0, lista.Length - 1);
        }


        public static void QuickSort(int[] lista, int inicio, int fin)
        {
            if (inicio < fin)
            {
                int pivoteIndex = Particionar(lista, inicio, fin);
                QuickSort(lista, inicio, pivoteIndex - 1);
                QuickSort(lista, pivoteIndex + 1, fin);
            }
        }


        private static int Particionar(int[] lista, int inicio, int fin)
        {
            int pivote = lista[fin];
            int i = inicio - 1;

            for (int j = inicio; j < fin; j++)
            {
                if (lista[j] <= pivote)
                {
                    i++;

                    Intercambiar(lista, i, j);
                }
            }


            Intercambiar(lista, i + 1, fin);
            return i + 1;
        }


        private static void Intercambiar(int[] lista, int a, int b)
        {
            int temp = lista[a];
            lista[a] = lista[b];
            lista[b] = temp;
        }
    }
}

