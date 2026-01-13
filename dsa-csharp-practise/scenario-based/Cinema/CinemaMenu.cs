using System;

namespace CinemaApp
{
    class Menu
    {
        private IMovieService service;

        public Menu(IMovieService service)
        {
            this.service = service;
        }

        public void ShowMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n====== CINEMA MENU ======");
                Console.WriteLine("1. Display All Movies");
                Console.WriteLine("2. Search Movie (keyword = Dark)");
                Console.WriteLine("3. Add Predefined Movie");
                Console.WriteLine("4. Generate Report");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                string input = Console.ReadLine();
                int.TryParse(input, out choice);   // ✅ FIXED

                switch (choice)
                {
                    case 1:
                        service.DisplayAllMovies();
                        break;

                    case 2:
                        service.SearchMovie("Dark");
                        break;

                    case 3:
                        service.AddMovie("Inception", "23:15");
                        break;

                    case 4:
                        service.GenerateReport(); // ✅ NOW WORKS
                        break;

                    case 0:
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != 0);
        }
    }
}
