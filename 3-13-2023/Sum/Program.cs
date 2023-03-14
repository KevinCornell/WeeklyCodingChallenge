using System;

public class Program
{
    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public static void Main()
    {
        //Examples
        Console.WriteLine("Sum(3,2) = {0}", Sum(3, 2));
        Console.WriteLine("Sum(-3,-6) = {0}", Sum(-3, -6));
        Console.WriteLine("Sum(7,3) = {0}", Sum(7, 3));
    }
}
