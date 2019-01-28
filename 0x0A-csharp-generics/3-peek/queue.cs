using System;

/// <summary>
/// Generic queue class
/// </summary>
/// <typeparam name="T">Type you would like the held values to be</typeparam>
class Queue<T>
{
    public Node head = null;
    public Node tail = null;
    private int count;

    /// <summary>
    /// Adds a new node to the queue with value of value.
    /// </summary>
    /// <param name="value">Value of the new node</param>
    public void Enqueue(T value)
    {
        Node temp = new Node(value);
        if (head == null)
        {
            head = temp;
            tail = temp;
        }
        else
        {
            tail.next = temp;
            tail = temp;
        }
        count++;
    }
    /// <summary>
    /// Removes front node from queue and returns it's value.
    /// </summary>
    /// <returns>Value of removed node if queue not empty; Otherwise default value.</returns>
    public T Dequeue()
    {
        Node temp = head;
        if (temp == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        head = head.next;
        count--;
        return temp.value;
    }
    /// <summary>
    /// Returns the value of the head node.
    /// </summary>
    /// <returns>Value if head exists; otherwise default value of queue type.</returns>
    public T Peek()
    {
        if (head == null)
            Console.WriteLine("Queue is empty");
        return head != null ? head.value : default(T);
    }
    /// <summary>
    /// Returns the count of the current queue
    /// </summary>
    /// <returns>Int of the count</returns>
    public int Count()
    {
        return count;
    }
    /// <summary>
    /// Class to describe nodes of the queue
    /// </summary>
    public class Node
    {
        public T value = default(T);
        public Node next = null;

        /// <summary>
        /// Constructor for the node class
        /// </summary>
        /// <param name="variable">Value to add to the node</param>
        public Node(T variable)
        {
            value = variable;
        }
    }
    /// <summary>
    /// Checks the type of the queue value
    /// </summary>
    /// <returns>Type of the queue value</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}
