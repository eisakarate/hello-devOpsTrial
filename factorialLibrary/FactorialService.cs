namespace factorialLibrary;

using System;

public class FactorialService
{
    public static int factorial(int n)
    {
        if (n < 0)
            throw new InvalidOperationException("Negative numbers don't have proper factorial");

        switch(n)
        {
            case 1:
            case 0:
                return 1; //0! => 1, 
            default:
                return n * factorial(n-1);
        }
    }
}
