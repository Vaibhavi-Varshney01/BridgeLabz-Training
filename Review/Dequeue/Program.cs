using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleDeque deque = new SimpleDeque(5);

        Console.WriteLine("Adding elements at rear:");
        deque.AddRear(10);
        deque.AddRear(20);
        deque.AddRear(30);
        deque.Display();

        Console.WriteLine("Adding element at front:");
        deque.AddFront(5);
        deque.Display();

        Console.WriteLine("Removing from front:");
        int removedFront = deque.RemoveFront();
        Console.WriteLine("Removed: " + removedFront);
        deque.Display();

        Console.WriteLine("Removing from rear:");
        int removedRear = deque.RemoveRear();
        Console.WriteLine("Removed: " + removedRear);
        deque.Display();
    }
}
