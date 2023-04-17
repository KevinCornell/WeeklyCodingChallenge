using System;

public class Program
{
    public static void Main()
    {
        //Teams Examples
        PrintExample("eDaBiT");
        PrintExample("eQuINoX");
        PrintExample("determine");
        PrintExample("STRIKE");
        PrintExample("sUn");

        //My Examples
        PrintExample("$peC@!l"); //should just be [3]
        PrintExample("W!th Sp@ceS"); //should just be [0,5,10]
        PrintExample(""); //should just be []

    }

    public static int[] IndexOfCapitals(string str)
    {
        int[] indexes = new int[0];

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] >= 65 && str[i] <= 90)
            {
                indexes = AddElement(indexes, i);
            }
        }

        return indexes;
    }

    //Helper method
    private static int[] AddElement(int[] arr, int val)
    {
        int[] newArr = new int[arr.Length + 1];

        for (int i = 0; i < arr.Length; i++) {
            newArr[i] = arr[i];
        }

        newArr[arr.Length] = val;

        return newArr;
    }

    //Helper method
    public static void PrintExample(string str)
    {
        int[] arr = IndexOfCapitals(str);
        Console.Write("IndexOfCapitals(\"{0}\") -> ", str);
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++) {
            if (i == arr.Length - 1)
            {
                Console.Write("{0}", arr[i]);
            } 
            else
            {
                Console.Write("{0},", arr[i]);
            }
        }
        Console.WriteLine("]");
    }
}
