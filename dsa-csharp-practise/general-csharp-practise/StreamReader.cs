using System;
using System.Diagnostics;
using System.Text;

class StreamReader
{
    static void Main()
    {
        int n = 100000; // try increasing to feel the pain 😅
        Stopwatch sw = new Stopwatch();

        // Using string (IMMUTABLE)
        sw.Start();
        string result1 = "";
        for (int i = 0; i < n; i++)
        {
            result1 += "A";
        }
        sw.Stop();
        Console.WriteLine("String Time: " + sw.ElapsedMilliseconds + " ms");

        // Using StringBuilder (MUTABLE)
        sw.Restart();
        StringBuilder result2 = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            result2.Append("A");
        }
        sw.Stop();
        Console.WriteLine("StringBuilder Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
