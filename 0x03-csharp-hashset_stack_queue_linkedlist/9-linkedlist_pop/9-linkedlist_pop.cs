using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        int hold = 0;
        if (myLList.Count > 0)
        {
            hold = myLList.First.Value;
            myLList.RemoveFirst();
        }
        return hold;
    }
}
