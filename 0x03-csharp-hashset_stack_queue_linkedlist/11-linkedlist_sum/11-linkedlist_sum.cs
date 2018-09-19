using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int total = 0;
        foreach (int nums in myLList)
        {
            total += nums;
        }
        return total;
    }
}
