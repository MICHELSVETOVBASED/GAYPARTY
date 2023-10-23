public static void Factorize(int number)
{
    /*List<int> newlist = new List<int>();

    for (int i = 1; i <= number; i++)
    {
        if (number % i == 0)
        {
            newlist.Add(i);
        }
    }
    for (int k = 0; k < newlist.Count / 2; k++)
    {

        Console.WriteLine($"{number} = {newlist[k]} * {newlist[newlist.Count - k - 1]}");
    }*/
    int[] dividers = new int[number];
    int[] dividers1 = new int[number];
    int N = 0;
    for (int i = 1; i <= number; i++)
    {
        if (number % i == 0)
        {
            dividers[i] = i;
            N++;
            int c = number / i;
            dividers1[i] = c;
        }
    }
    int[] arr = new int[N];
    int j = 0;
    for (int i = 0; i <= arr.Length; i++)
    {
        if (dividers[i] != 0)
        {
            arr[j] = dividers[i];
            j++;
        }

    }
    int[] arr1 = new int[N];
    int l = 0;
    for (int i = 0; i <= arr1.Length; i++)
    {
        if (dividers1[i] != 0)
        {
            arr1[l] = dividers1[i];
            l++;
        }

    }
    for (int k = 0; k <= arr.Length; k++)
    {
       return Console.WriteLine($"{number} = {arr1[k]} * {arr[k]}");
    }
}