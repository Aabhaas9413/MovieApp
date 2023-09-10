using MovieDataAccess.Models;

namespace MovieDataAccess.MovieData
{
    public interface IMovieData
    {
        Task<Movie> GetMovieByIMDbId(string id);
        Task<Movie> GetMovieByTitle(string title);
        Task<MovieSearchResponse> GetMovieListByTitle(string title, int page);
    }
}