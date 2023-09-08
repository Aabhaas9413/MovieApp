using Microsoft.Extensions.Configuration;
using MovieDataAccess.Models;
using System.Configuration;

namespace MovieDataAccess.MovieData
{
    public class MovieData : IMovieData
    {
        public readonly string apiUrl;
        public readonly string apiKey;
        public readonly IMovieDataAccess _movieDataAccess;

        private readonly IConfiguration _config;
        public MovieData(IConfiguration config, IMovieDataAccess movieDataAccess)
        {
            _config = config;
            apiUrl = _config.GetSection("ApiEndpoint").Value;
            apiKey = _config.GetSection("ApiKey").Value;
            _movieDataAccess = movieDataAccess;
        }
        public async Task<List<MovieSearch>> GetMovieListByTitle(string title, int page)
        {
            var moviePath = apiUrl + $"?s={title}&page={page}&apikey=" + apiKey;
            MovieSearchResponse res = await _movieDataAccess.getDataFromResponseObj<MovieSearchResponse>(moviePath);
            return res.Search;
        }

        public async Task<Movie> GetMovieByTitle(string title)
        {
            var moviePath = apiUrl + $"?t={title}&apikey=" + apiKey;
            Movie res = await _movieDataAccess.getDataFromResponseObj<Movie>(moviePath);
            return res;
        }
        public async Task<Movie> GetMovieByIMDbId(string id)
        {
            var moviePath = apiUrl + $"?i={id}&apikey=" + apiKey;
            Movie res = await _movieDataAccess.getDataFromResponseObj<Movie>(moviePath);
            return res;
        }

    }
}
