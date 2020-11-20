//Ruth Martínez Iborra
/* Calculate the average of the marks entered by the user until they 
 * type "end". */
 
using System;
public class Average
{
    public static void Main()
    {
        double totalMark = 0, mark, quantityMarks = 0, averageMark;
        string markOrEnd;

        Console.Write("Insert a mark: ");
        markOrEnd = Console.ReadLine();

        while (markOrEnd != "end")
        {  
            mark = Convert.ToDouble(markOrEnd);
            quantityMarks++; 
            totalMark += mark;

            Console.Write("Insert a mark: ");
            markOrEnd = Console.ReadLine();
        }

        if (quantityMarks != 0)
        {
            averageMark = totalMark / quantityMarks;  
            Console.WriteLine("The average is {0}.", averageMark);
        }
    }
}
