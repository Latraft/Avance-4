using System;



namespace BúsquedaPorHashing

{
    public class Ordenad
    {

        public static int FunciónHash(int clave, int tamañoTabla)
        {
            return clave % tamañoTabla;
        }


        public static int BúsquedaPorHashing(int[] tabla, int clave)
        {
            int tamañoTabla = tabla.Length;
            int índice = FunciónHash(clave, tamañoTabla);


            if (tabla[índice] == clave)
            {
                return índice;
            }

            return -1;
        }

    }
}
