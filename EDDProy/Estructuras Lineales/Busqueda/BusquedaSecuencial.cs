using System;

namespace BúsquedaSecuencial
{
    public static class Ordenador
    {

        public static int BúsquedaSecuencial(int[] arr, int objetivo)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == objetivo)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}