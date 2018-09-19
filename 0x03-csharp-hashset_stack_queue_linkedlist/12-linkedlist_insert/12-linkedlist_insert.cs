using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> node = null;
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);
        int broke = 0;
        foreach (int nums in myLList)
        {
            if (n < nums)
            {
                node = myLList.Find(nums);
                broke = 1;
                break;
            }
        }
        if (broke == 0)
        {
            myLList.AddLast(node);
        }
        if (node != null)
        {
            myLList.AddBefore(node, newNode);
        }
        return newNode;
    }
}
