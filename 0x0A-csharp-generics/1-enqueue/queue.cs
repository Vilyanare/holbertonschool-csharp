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
