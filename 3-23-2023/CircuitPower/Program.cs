using System;

public class Program
{
    public static int CircuitPower(int v, int c)
    {
        return v * c;
    }

    public static void Main()
    {
        //Examples
        Console.WriteLine("CircuitPower(230,10) = {0}", CircuitPower(230, 10));
        Console.WriteLine("CircuitPower(110,3) = {0}", CircuitPower(110, 3));
        Console.WriteLine("CircuitPower(480,20) = {0}", CircuitPower(480, 20));
    }
}
