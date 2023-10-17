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
        string s = "124124124";
        int[] ints = new int[s.Length];
        for (int i = 0; i < ints.Length; i++)
        {
            int n = (int)char.GetNumericValue(s[i]);
            ints[i] = n;
            Console.WriteLine(
        }
    }
}

