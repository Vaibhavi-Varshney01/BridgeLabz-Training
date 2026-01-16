using System;

namespace TrafficManagerApp
{
    class QueueLinkedList
    {
        private Node front, rear;
        private int size = 0;
        private int capacity;

        public QueueLinkedList(int capacity)
        {
            this.capacity = capacity;
        }

        public void Enqueue(Vehicle vehicle)
        {
            if (size == capacity)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }

            Node node = new Node(vehicle);

            if (rear == null)
                front = rear = node;
            else
            {
                rear.Next = node;
                rear = node;
            }

            size++;
            Console.WriteLine("Vehicle waiting: " + vehicle);
        }

        public Vehicle Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("Queue Underflow");
                return null;
            }

            Vehicle v = front.Data;
            front = front.Next;
            size--;

            if (front == null)
                rear = null;

            return v;
        }
    }
}
