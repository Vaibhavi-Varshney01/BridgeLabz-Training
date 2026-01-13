namespace CinemaApp
{
    public interface IMovieService
    {
        void AddMovie(string title, string time);
        void SearchMovie(string keyword);
        void DisplayAllMovies();
        void GenerateReport();   // 🔥 THIS IS MANDATORY
    }
}
