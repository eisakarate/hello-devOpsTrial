namespace factorialLibrary;

public class FactorialService
{
    public static int factorial(int n)
    {
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
