using System;

public class CalculoExponente
{

    public static double Potencia(double baseNumber, int exponent)
    {

        if (exponent == 0)
        {
            return 1;
        }

        if (exponent == 1)
        {
            return baseNumber;
        }

        return baseNumber * Potencia(baseNumber, exponent - 1);
    }
}
