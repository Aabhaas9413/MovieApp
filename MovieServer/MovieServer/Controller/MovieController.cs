using Microsoft.AspNetCore.Mvc;
using MovieDataAccess.MovieData;

namespace MovieAPI.Controller
{
    public static class MovieController
    {
        public static void ConfigureApi(this WebApplication app)
        {
            app.MapGet("getMovieListByTitle/{title}/{page}", GetMovieListByTitle);
            app.MapGet("getMovieByTitle/{title}", GetMovieByTitle);
            app.MapGet("getMovieByIMDbId/{id}", GetMovieByIMDbId);
        }

        private static async Task<IResult> GetMovieListByTitle(string title, int page, IMovieData data)
        {
            try
            {
                var results = await data.GetMovieListByTitle(title, page);

                if (results == null) { return Results.NotFound(); }
                return Results.Ok(results);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> GetMovieByTitle(string title, IMovieData data)
        {
            try
            {
                var results = await data.GetMovieByTitle(title);

                if (results == null) { return Results.NotFound(); }
                return Results.Ok(results);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> GetMovieByIMDbId(string id, IMovieData data)
        {
            try
            {
                var results = await data.GetMovieByIMDbId(id);

                if (results == null) { return Results.NotFound(); }
                return Results.Ok(results);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
