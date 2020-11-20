//Ruth Martínez Iborra
// A program that shows you the number of digits a number has

using System;

class digits
{
    static void Main()
    {
        int oneDigit = 0, twoDigits = 0, threeDigits = 0, restOfDigits = 0;

        Console.Write("Insert a number: ");
        string number = Console.ReadLine();

        while (number != "end")
        {
            int input = Convert.ToInt32(number);

            if (input != 0)
            {
                if (input / 10 == 0)
                    oneDigit++;  
                else if (input / 100 == 0) 
                    twoDigits++;  
                else if (input / 1000 == 0)
                    threeDigits++;  
                else
                    restOfDigits++; 
            }
            number = Console.ReadLine();
        }
        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}",
         oneDigit, twoDigits, threeDigits, restOfDigits);
    }
}
