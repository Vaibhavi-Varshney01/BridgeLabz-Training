sealed class Menu
{
    static string[] items = { "Burger","Pizza","Sandwich","Pasta","Noodles",
                             "Coffee","Tea","Fries","Momos","Cold Drink" };

    static double[] prices = { 120,200,100,150,130,80,50,70,90,60 };

    public static void DisplayMenu()
    {
        Console.WriteLine("---- Cafeteria Menu ----");
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine($"{i} : {items[i]} - ₹{prices[i]}");
        }
    }

    public static string GetItemByIndex(int index)
    {
        if (index >= 0 && index < items.Length)
            return items[index];
        else
            return "Invalid Item Selected";
    }

    public static double GetPriceByIndex(int index)
    {
        if (index >= 0 && index < prices.Length)
            return prices[index];
        else
            return 0;
    }

    public static bool IsAvailable(string name)
    {
        foreach(var item in items)
            if(item.Equals(name, StringComparison.OrdinalIgnoreCase))
                return true;
        return false;
    }
}
