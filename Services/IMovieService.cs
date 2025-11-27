using MovieApp.Models;
namespace MovieApp.Services;

public interface IMovieService
{
    Task<List<Movie>> SearchMoviesAsync(string searchTerm);
    Task<MovieDetail?> GetMovieDetailsAsync(string imdbId);
}

