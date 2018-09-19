using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> node = null;
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);
        foreach (int nums in myLList)
        {
            if (n < nums)
            {
                node = myLList.Find(nums);
                break;
            }
        }
        myLList.AddBefore(node, newNode);
        return newNode;
    }
}
