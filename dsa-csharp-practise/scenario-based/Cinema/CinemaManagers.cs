using System;

namespace CinemaApp
{
    class CinemaManager : IMovieService
    {
        private Movie[] movies;
        private int count;

        public CinemaManager()
        {
            movies = new Movie[20];
            count = 0;

            AddMovie("Kantara 2", "18:30");
            AddMovie("Interstellar", "21:15");
            AddMovie("Avatar", "16:00");
            AddMovie("Titanic", "14:45");
            AddMovie("Joker", "19:00");
            AddMovie("Avengers", "20:30");
            AddMovie("Oppenheimer", "22:00");
            AddMovie("Matrix", "17:15");
            AddMovie("Gladiator", "13:30");
            AddMovie("Dark Knight", "15:45");
        }

        public void AddMovie(string title, string time)
        {
            if (!IsValidTime(time) || count >= movies.Length)
                return;

            movies[count++] = new Movie(title, time);
        }

        public void SearchMovie(string keyword)
        {
            for (int i = 0; i < count; i++)
            {
                if (movies[i].Title.Contains(keyword,
                    StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{movies[i].Title} at {movies[i].Time}");
                }
            }
        }

        public void DisplayAllMovies()
        {
            Console.WriteLine("\n--- Movie Schedule ---");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{movies[i].Title} - {movies[i].Time}");
            }
        }

        public void GenerateReport()
        {
            Movie[] report = new Movie[count];
            Array.Copy(movies, report, count);

            Console.WriteLine("\n--- Printable Report ---");
            foreach (Movie m in report)
            {
                Console.WriteLine($"{m.Title} --> {m.Time}");
            }
        }

        private bool IsValidTime(string time)
        {
            string[] p = time.Split(':');
            return p.Length == 2 &&
                   int.TryParse(p[0], out int h) &&
                   int.TryParse(p[1], out int m) &&
                   h >= 0 && h <= 23 &&
                   m >= 0 && m <= 59;
        }
    }
}
