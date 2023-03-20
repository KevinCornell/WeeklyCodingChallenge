using System;

public class Program
{
    public static bool CheckEquality(object a, object b)
    {
        if (a.GetType() != b.GetType())
        {
            return false;
        }

        return a.Equals(b);
    }
    public static void Main()
    {
        //Examples
        Console.WriteLine("CheckEquality(1,true) = {0}", CheckEquality(1, true));
        Console.WriteLine("CheckEquality(0,\"0\") = {0}", CheckEquality(0, "0"));
        Console.WriteLine("CheckEquality(1,1) = {0}", CheckEquality(1, 1));

        //My Examples
        Console.WriteLine("CheckEquality(\"Hello\",\"World!\") = {0}", CheckEquality("Hello", "World!"));
        Console.WriteLine("CheckEquality(\"Hello World!\",\"Hello World!\") = {0}", CheckEquality("Hello World!", "Hello World!"));
        Console.WriteLine("CheckEquality(true,false) = {0}", CheckEquality(true, false));
        Console.WriteLine("CheckEquality(false,false) = {0}", CheckEquality(false, false));

    }
}
