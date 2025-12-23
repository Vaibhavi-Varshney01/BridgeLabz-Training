using System;
class PCM{
    static void Main(){
        Console.Write("Enter Physics marks: ");
        int phy = int.Parse(Console.ReadLine());
        Console.Write("Enter Chemistry marks: ");
        int chem = int.Parse(Console.ReadLine());
        Console.Write("Enter Maths marks: ");
        int maths = int.Parse(Console.ReadLine());
        double average = (phy + chem + maths) / 3.0;
        Console.WriteLine("Average Marks: " + average);
        if (average >= 90)
            Console.WriteLine("Grade: A | Remarks: Excellent");
        else if (average >= 75)
            Console.WriteLine("Grade: B | Remarks: Very Good");
        else if (average >= 60)
            Console.WriteLine("Grade: C | Remarks: Good");
        else if (average >= 40)
            Console.WriteLine("Grade: D | Remarks: Pass");
        else
            Console.WriteLine("Grade: F | Remarks: Fail");
    }
}
