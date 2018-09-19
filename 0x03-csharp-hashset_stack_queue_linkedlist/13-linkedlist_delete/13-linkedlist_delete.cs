using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> remove = null;
        int count = 0;
        foreach (int nums in myLList)
        {
            if (count == index)
            {
                remove = myLList.Find(nums);
                break;
            }
            count++;
        }
        myLList.Remove(remove);
    }
}
