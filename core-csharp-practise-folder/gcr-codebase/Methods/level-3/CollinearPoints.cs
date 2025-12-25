using System;
class CollinearPoints{
    static bool AreCollinear(int x1, int y1,
                             int x2, int y2,
                             int x3, int y3)
    {
        int area = x1 * (y2 - y3)
                 + x2 * (y3 - y1)
                 + x3 * (y1 - y2);
        return area == 0;
    }
    static void Main(){
        Console.WriteLine("Enter coordinates of Point A:");
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter coordinates of Point B:");
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter coordinates of Point C:");
        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());
        if (AreCollinear(x1, y1, x2, y2, x3, y3))
            Console.WriteLine("Points are COLLINEAR");
        else
            Console.WriteLine("Points are NOT Collinear");
    }
}
