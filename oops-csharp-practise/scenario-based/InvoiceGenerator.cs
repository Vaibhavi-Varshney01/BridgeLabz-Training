using System;
class InvoiceGenerator{
    //Parse invoice string into tasks
    static string[] ParseInvoice(string input){
        // Split invoice into individual tasks
        string[] tasks = input.Split(',');
        return tasks;
    }
    // Calculate total amount
    static int GetTotalAmount(string[] tasks){
        int total = 0;
        foreach (string task in tasks){
            // Split task name and amount
            string[] parts = task.Split('-');
            // Extract amount part
            string amountPart = parts[1];
            // Remove "INR" and spaces
            amountPart = amountPart.Replace("INR", "").Trim();
            // Convert to integer and add
            int amount = int.Parse(amountPart);
            total += amount;
        }
        return total;
    }
    static void Main(){
        string input = "Logo Design - 3000 INR, Web Page - 4500 INR";
        // Parse invoice
        string[] tasks = ParseInvoice(input);
        Console.WriteLine("Invoice Details:");
        foreach (string task in tasks){
            Console.WriteLine(task.Trim());
        }
        // Calculate total
        int totalAmount = GetTotalAmount(tasks);
        Console.WriteLine("\nTotal Invoice Amount: " + totalAmount + " INR");
    }
}
