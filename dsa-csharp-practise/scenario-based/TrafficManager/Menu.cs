using System;

namespace TrafficManagerApp
{
    class Menu
    {
        CircularLinkedList roundabout = new CircularLinkedList();
        QueueLinkedList queue = new QueueLinkedList(4);

        public void Start()
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== TRAFFIC MANAGER =====");
                Console.WriteLine("1. Add Vehicle to Queue");
                Console.WriteLine("2. Move Vehicle to Roundabout");
                Console.WriteLine("3. Remove Vehicle from Roundabout");
                Console.WriteLine("4. Display Roundabout");
                Console.WriteLine("5. Exit");
                Console.Write("Choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Vehicle Number: ");
                        queue.Enqueue(new Vehicle(Console.ReadLine()));
                        break;

                    case 2:
                        Vehicle v = queue.Dequeue();
                        if (v != null)
                            roundabout.Insert(v);
                        break;

                    case 3:
                        roundabout.Delete();
                        break;

                    case 4:
                        roundabout.Display();
                        break;

                    case 5:
                        Console.WriteLine("Exit");
                        break;
                }

            } while (choice != 5);
        }
    }
}
