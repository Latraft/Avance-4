using System;

public class SumarArreglos
{

    public static int SumArrayElements(int[] array)
    {
        return SumArrayElementsRecursive(array, 0);
    }


    private static int SumArrayElementsRecursive(int[] array, int index)
    {

        if (index >= array.Length)
        {
            return 0;
        }


        return array[index] + SumArrayElementsRecursive(array, index + 1);
    }
}