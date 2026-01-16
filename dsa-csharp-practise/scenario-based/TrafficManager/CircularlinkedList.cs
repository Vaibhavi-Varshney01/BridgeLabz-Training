using System;

namespace TrafficManagerApp
{
    class CircularLinkedList
    {
        private Node head = null;

        public void Insert(Vehicle vehicle)
        {
            Node newNode = new Node(vehicle);

            if (head == null)
            {
                head = newNode;
                head.Next = head;
            }
            else
            {
                Node temp = head;
                while (temp.Next != head)
                    temp = temp.Next;

                temp.Next = newNode;
                newNode.Next = head;
            }

            Console.WriteLine("Vehicle entered roundabout: " + vehicle);
        }

        public void Delete()
        {
            if (head == null)
            {
                Console.WriteLine("Roundabout empty");
                return;
            }

            if (head.Next == head)
            {
                Console.WriteLine("Vehicle exited: " + head.Data);
                head = null;
                return;
            }

            Node temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            Console.WriteLine("Vehicle exited: " + head.Data);
            temp.Next = head.Next;
            head = head.Next;
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Roundabout empty");
                return;
            }

            Node temp = head;
            Console.Write("Roundabout: ");

            do
            {
                Console.Write(temp.Data + " -> ");
                temp = temp.Next;
            }
            while (temp != head);

            Console.WriteLine("(back to start)");
        }
    }
}
