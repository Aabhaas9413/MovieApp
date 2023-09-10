using Microsoft.Extensions.Configuration;
using MovieDataAccess.Models;

namespace MovieDataAccess.MovieData
{
    public class MovieData : IMovieData
    {
        public readonly string apiUrl;
        public readonly string apiKey;
        public readonly IDataAccess _movieDataAccess;

        private readonly IConfiguration _config;
        public MovieData(IConfiguration config, IDataAccess movieDataAccess)
        {
            _config = config;
            apiUrl = _config.GetSection("ApiEndpoint")?.Value;
            apiKey = _config.GetSection("ApiKey")?.Value;
            _movieDataAccess = movieDataAccess;
        }
        public async Task<MovieSearchResponse> GetMovieListByTitle(string title, int page)
        {
            try
            {
                var moviePath = apiUrl + $"?s={title}&page={page}&apikey=" + apiKey;
                MovieSearchResponse res = await _movieDataAccess.getDataFromResponseObj<MovieSearchResponse>(moviePath);
                return res;
            }
            catch
            {
                throw;
            }
        }

        public async Task<Movie> GetMovieByTitle(string title)
        {
            try
            {
                var moviePath = apiUrl + $"?t={title}&apikey=" + apiKey;
                Movie res = await _movieDataAccess.getDataFromResponseObj<Movie>(moviePath);
                return res;
            }
            catch
            {
                throw;
            }
        }
        public async Task<Movie> GetMovieByIMDbId(string id)
        {
            try
            {
                var moviePath = apiUrl + $"?i={id}&apikey=" + apiKey;
                Movie res = await _movieDataAccess.getDataFromResponseObj<Movie>(moviePath);
                return res;
            }
            catch
            {
                throw;
            }

        }

    }
}
