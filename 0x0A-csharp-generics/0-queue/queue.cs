using System;

/// <summary>
/// Generic queue class
/// </summary>
/// <typeparam name="T">Type you would like the held values to be</typeparam>
class Queue<T>
{
    /// <summary>
    /// Checks the type of the queue value
    /// </summary>
    /// <returns>Type of the queue value</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}
