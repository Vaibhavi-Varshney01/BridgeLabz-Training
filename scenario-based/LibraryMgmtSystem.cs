using System;
class LibraryMgmtSystem{
    static string[,] books = {
        {"Harry Potter", "J.K. Rowling", "Available"},
        {"Tom Sawyer", "Mark Twain", "Available"},
        {"Pride and Prejudice", "Jane Austen", "Checked Out"},
        {"The Guide", "R.K. Narayan", "Available"},
        {"Gitanjali", "Rabindranath Tagore", "Checked Out"},
        {"Dune", "Frank Herbert", "Available"},
        {"The Hunger Games", "Suzanne Collins", "Available"},
        {"The Time Machine", "H.G. Wells", "Checked Out"},
        {"Train to Pakistan", "Khushwant Singh", "Available"},
        {"The Republic", "Plato", "Checked Out"}
    };
    static void Main(){
        int role;
        int choice;
        Console.WriteLine("---- Library Management System ----");
        Console.WriteLine("Select Role:");
        Console.WriteLine("1. Admin");
        Console.WriteLine("2. User");
        role = Convert.ToInt32(Console.ReadLine());
        switch (role){
            case 1:
                Console.Write("Enter Admin Password: ");
                string password = Console.ReadLine();
                if (password != "#rajma_chawal0102"){
                    Console.WriteLine("Wrong Password! Access Denied.");
                    break;
                }
                do{
                    Console.WriteLine("--- ADMIN MENU ---");
                    Console.WriteLine("1. View Books");
                    Console.WriteLine("2. Add Book");
                    Console.WriteLine("3. Update Book Status");
                    Console.WriteLine("4. Exit");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice){
                        case 1:
                            DisplayBooks();
                            break;
                        case 2:
                            AddBook();
                            break;
                        case 3:
                            UpdateBookStatus();
                            break;
                        case 4:
                            Console.WriteLine("Admin Logged Out");
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                } 
                while (choice != 4);
                break;
            case 2:
                do
                {
                    Console.WriteLine("\n--- USER MENU ---");
                    Console.WriteLine("1. Search Book");
                    Console.WriteLine("2. Display Books");
                    Console.WriteLine("3. Check Availability");
                    Console.WriteLine("4. Exit");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice){
                        case 1:
                            SearchBooks();
                            break;
                        case 2:
                            DisplayBooks();
                            break;
                        case 3:
                            CheckStatus();
                            break;
                        case 4:
                            Console.WriteLine("User Logged Out");
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                } while (choice != 4);
                break;
            default:
                Console.WriteLine("Invalid Role Selected");
                break;
        }
    }
    static void AddBook(){
        Console.WriteLine("Add Book feature is limited because array size is fixed.");
        Console.WriteLine("Use List in real applications.");
    }
    static void UpdateBookStatus(){
        Console.Write("Enter Book Name to Update Status: ");
        string name = Console.ReadLine().ToLower();
        bool found = false;
        for (int i = 0; i < books.GetLength(0); i++){
            if (books[i, 0].ToLower().Contains(name)){
                Console.WriteLine("Current Status: " + books[i, 2]);
                Console.Write("Enter New Status (Available / Checked Out): ");
                books[i, 2] = Console.ReadLine();
                Console.WriteLine("Status Updated Successfully");
                found = true;
            }
        }
        if (!found)
        {
          Console.WriteLine("Book Not Found");
        }
    }
    static void SearchBooks(){
        Console.Write("Enter Book Name: ");
        string name = Console.ReadLine().ToLower();
        bool found = false;
        for (int i = 0; i < books.GetLength(0); i++){
            if (books[i, 0].ToLower().Contains(name)){
                Console.WriteLine("Title: " + books[i, 0] +
                                  " | Author: " + books[i, 1] +
                                  " | Status: " + books[i, 2]);
                found = true;
            }
        }
        if (!found){
            Console.WriteLine("Book Not Found");
        }
    }
    static void DisplayBooks(){
        for (int i = 0; i < books.GetLength(0); i++){
            Console.WriteLine(books[i, 0] + " | " + books[i, 1] + " | " + books[i, 2]);
        }
    }
    static void CheckStatus(){
        for (int i = 0; i < books.GetLength(0); i++)
        {
          Console.WriteLine(books[i, 0] + " -> " + books[i, 2]);
        }
    }
}
