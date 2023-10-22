public static bool IsTextIncludesChar(string text)
{
    public static void Main()
    {
        string grades = Console.ReadLine();
        string[] newstring = grades.Split(',');
        int[] numbers = new int[newstring.Length];
        bool ValueReq;
        for (int i = 0; i < newstring.Length; i++)
        {
            numbers[i] = int.Parse(newstring[i]);
        }
        if (numbers[0] == 5 && numbers[1] == 5 && numbers[2] == 5 && numbers[3] == 5)
        {
            bool ValueReq = true;

        }
        else
        {
            bool ValueReq = false;
 
        }
        foreach (int x in numbers)
        {
            if (x == 2)
            {
                Console.WriteLine("Ну что, студент, пора долг Родине отдать");
                return;
            }

            if (x == 3)
            {
                Console.WriteLine("Прощай стипендия!");
                return;
            }



            else if (x != 2 && x != 3 & ValueReq == false)
            {
                Console.WriteLine("Живи пока, через полгода увидимся");
                return;
            }
            else continue;



        }
        if (numbers[0] == 5 && numbers[1] == 5 && numbers[2] == 5 && numbers[3] == 5)
        {
            Console.WriteLine("О, отличник появился! На олимпиаду пойдешь");
            Console.WriteLine("О, отличник появился! На олимпиаду пойдешь"); Console.WriteLine("О, отличник появился! На олимпиаду пойдешь");
            Console.WriteLine("О, отличник появился! На олимпиаду пойдешь");
            Console.WriteLine("О, отличник появился! На олимпиаду пойдешь");


        }
    }
        

        
        
}
