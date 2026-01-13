using System;

namespace CinemaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovieService manager = new CinemaManager();
            Menu menu = new Menu(manager);
            menu.ShowMenu();
        }
    }
}
