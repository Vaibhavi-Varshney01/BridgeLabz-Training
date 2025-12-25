using System;
class Marks{
    static void Main(){
        Console.Write("Students: ");
        int n = int.Parse(Console.ReadLine());
        Random r = new Random();
        for (int i = 0; i < n; i++){
            int p = r.Next(10,99);
            int c = r.Next(10,99);
            int m = r.Next(10,99);
            int total = p + c + m;
            double avg = Math.Round(total / 3.0, 2);
            double per = Math.Round((total / 300.0) * 100, 2);
            Console.WriteLine($"{p}\t{c}\t{m}\t{total}\t{avg}\t{per}");
        }
    }
}
