using System.Numerics;

public static class CalculadoraFactorial
{
    public static BigInteger Factorial(int n)
    {
        if (n <= 1) return 1;
        return n * Factorial(n - 1);
    }
}
