using System;
using System.Globalization;

public class MainClass
{
    public static void Main()
    {
        /*string cardNumber = Console.ReadLine();
        int[] intcard = new int[cardNumber.Length];
        for (int i = 0; i < cardNumber.Length; i++)
        {
            int n = (int)char.GetNumericValue(cardNumber[i]);
            int[] intcard = n;

            Console.WriteLine(intcard[i]);


        */
        string s = Console.ReadLine();
        int[] ints = new int[s.Length];
        for (int i = 0; i < ints.Length; i++)
        {
            int n = (int)char.GetNumericValue(s[i]); // создается рандомный n,
            ints[i] = n;                       // , а потом его вводят в каждый элемент инта i 
        }
        int maxValue = ints.Max();
        int minValue = ints.Min();
        Console.Write(minValue);
        Console.Write(maxValue);

        Array.Reverse(ints);
        for ( int i = 0; i < ints.Length; ++i )
        {
        }
    }
}

