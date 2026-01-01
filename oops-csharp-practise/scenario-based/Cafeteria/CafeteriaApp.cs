using System;

class CafeteriaApp
{
    string[] orders = new string[10]; 
    int orderCount = 0;
    double total = 0;

    public void Run()
    {
        bool keepOrdering = true;

        while (keepOrdering && orderCount < orders.Length)
        {
            Menu.DisplayMenu();
            TakeOrder();

            Console.Write("\nDo you want to order more? (y/n): ");
            string input = Console.ReadLine();
            if (input.ToLower() != "y")
                keepOrdering = false;
        }

        Console.WriteLine("\n--- Your Orders ---");
        for (int i = 0; i < orderCount; i++)
            Console.WriteLine(orders[i]);

        Console.WriteLine("Total Bill: ₹" + total);
    }

    void TakeOrder()
    {
        Console.Write("\nEnter item index or name: ");
        string input = Console.ReadLine();

        if(int.TryParse(input, out int index))
        {
            string item = Menu.GetItemByIndex(index);
            double price = Menu.GetPriceByIndex(index);

            if(price == 0)
                Console.WriteLine("Invalid index!");
            else
                AddOrder(item, price);
        }
        else
        {
            CheckAvailability(input);
        }
    }

    void CheckAvailability(string name)
    {
        if(Menu.IsAvailable(name))
        {
            int index = Array.FindIndex(MenuItems(), x => x.Equals(name, StringComparison.OrdinalIgnoreCase));
            double price = Menu.GetPriceByIndex(index);
            AddOrder(name, price);
        }
        else
            Console.WriteLine("Sorry! Item not available.");
    }

    void AddOrder(string item, double price)
    {
        if(orderCount < orders.Length)
        {
            orders[orderCount] = item;
            orderCount++;
            total += price;
            Console.WriteLine($"Added {item} - ₹{price}");
        }
        else
            Console.WriteLine("Order limit reached!");
    }

    string[] MenuItems()
    {
        return new string[] { "Burger","Pizza","Sandwich","Pasta","Noodles",
                              "Coffee","Tea","Fries","Momos","Cold Drink" };
    }
}
