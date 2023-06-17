namespace DelegateExamples;

public static class Calculator
{
    public static int Addition(int n1, int n2)
    {
        return n1 + n2;
    }

    public static int Subtraction(int n1, int n2)
    {
        return Math.Abs(n1 - n2);
    }

    public static bool IsEven(int n1)
    {
        return (n1 & 1) == 0;
    }

    public static bool IsOdd(int n1)
    {
        return (n1 & 1) == 1;
    }
}
