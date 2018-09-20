using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> newL = new List<int>();
        for (int i = 0; i < listLength; i++)
        {
            try
            {
                newL.Add(list1[i] / list2[i]);
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                newL.Add(0);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
                break;
            }
        }
        return newL;
    }
}
