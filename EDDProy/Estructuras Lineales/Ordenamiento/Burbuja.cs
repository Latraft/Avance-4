using System;

class Burbujas

{
    static void Burbuja(int[] lista)
    {
        int n = lista.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (lista[j] > lista[j + 1])
                {
                   

                    int temp = lista[j];
                    lista[j] = lista[j + 1];
                    lista[j + 1] = temp;
                }
            }
        }
    }

    static void MostrarLista(int[] lista)
    {
        foreach (var item in lista)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}