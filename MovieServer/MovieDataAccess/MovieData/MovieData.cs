using MovieDataAccess.Models;
using System.Text.Json;

namespace MovieDataAccess.MovieData
{
    public class MovieData : IMovieData
    {
        public async Task<List<MovieSearch>?> GetMovieListByTitle(string title, int page)
        {
            var moviePath = $"http://www.omdbapi.com/?s={title}&apikey=10e7775&page={page}";
            MovieSearchResponse res = await MovieDataAccess.getDataFromResponseObj<MovieSearchResponse>(moviePath);
            return res.Search;
        }

        public async Task<Movie> GetMovieByTitle(string title)
        {
            var moviePath = $"http://www.omdbapi.com/?t={title}&apikey=10e7775";
            Movie res = await MovieDataAccess.getDataFromResponseObj<Movie>(moviePath);
            return res;
        }
        public async Task<Movie> GetMovieByIMDbId(string id)
        {
            var moviePath = $"http://www.omdbapi.com/?i={id}&apikey=10e7775";
            Movie res = await MovieDataAccess.getDataFromResponseObj<Movie>(moviePath);
            return res;
        }

    }
}
