using System;

public class SimpleDeque
{
    private int[] arr;
    private int front;
    private int size;
    private int capacity;

    public SimpleDeque(int capacity)
    {
        if (capacity <= 0)
            throw new ArgumentException("Capacity must be greater than 0");

        this.capacity = capacity;
        arr = new int[capacity];
        front = 0;
        size = 0;
    }

    public bool IsEmpty()
    {
        return size == 0;
    }

    public bool IsFull()
    {
        return size == capacity;
    }

    public void AddRear(int value)
    {
        if (IsFull())
            throw new InvalidOperationException("Deque is Full");

        int rear = (front + size) % capacity;  // calculate rear index
        arr[rear] = value;
        size++;
    }

    public void AddFront(int value)
    {
        if (IsFull())
            throw new InvalidOperationException("Deque is Full");

        front = (front - 1 + capacity) % capacity;  // move front backward
        arr[front] = value;
        size++;
    }

    public int RemoveFront()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Deque is Empty");

        int value = arr[front];
        front = (front + 1) % capacity;  // move front forward
        size--;
        return value;
    }

    public int RemoveRear()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Deque is Empty");

        int rear = (front + size - 1 + capacity) % capacity;
        int value = arr[rear];
        size--;
        return value;
    }

    public void Display()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Deque is empty");
            return;
        }

        Console.Write("Deque elements: ");
        for (int i = 0; i < size; i++)
        {
            int index = (front + i) % capacity;
            Console.Write(arr[index] + " ");
        }
        Console.WriteLine();
    }
}
