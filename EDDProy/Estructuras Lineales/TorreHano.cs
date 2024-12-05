using System;
using System.Collections.Generic;

public class TorreHano
{
    
    public static void MostrarEstado(List<int> varillaA, List<int> varillaB, List<int> varillaC)
    {
        Console.WriteLine("Estado actual de las varillas:");
        MostrarVarilla('A', varillaA);
        MostrarVarilla('B', varillaB);
        MostrarVarilla('C', varillaC);
        Console.WriteLine();
    }

    public static void MostrarVarilla(char varilla, List<int> discos)
    {
        Console.Write($"Varilla {varilla}: ");
        if (discos.Count == 0)
        {
            Console.WriteLine("Vacía");
        }
        else
        {
            foreach (int disco in discos)
            {
                Console.Write(disco + " ");
            }
            Console.WriteLine();
        }
    }

    // Método recursivo para resolver el problema de la Torre de Hanoi
    public static void Solve(int numberOfDiscs, List<int> fromRod, List<int> toRod, List<int> auxRod)
    {
        if (numberOfDiscs == 1)
        {
            // Mover el disco y mostrar el estado
            int disc = fromRod[0];
            fromRod.RemoveAt(0);
            toRod.Insert(0, disc);
            Console.WriteLine($"Mueve disco 1 de {fromRod[0]} a {toRod[0]}");
            MostrarEstado(fromRod, auxRod, toRod);
            return;
        }

        // Mover los discos a la varilla auxiliar
        Solve(numberOfDiscs - 1, fromRod, auxRod, toRod);

        // Mover el disco actual
        int currentDisc = fromRod[0];
        fromRod.RemoveAt(0);
        toRod.Insert(0, currentDisc);
        Console.WriteLine($"Mueve disco {numberOfDiscs} de {fromRod[0]} a {toRod[0]}");
        MostrarEstado(fromRod, auxRod, toRod);

        // Mover los discos de la varilla auxiliar a la varilla de destino
        Solve(numberOfDiscs - 1, auxRod, toRod, fromRod);
    }
}

