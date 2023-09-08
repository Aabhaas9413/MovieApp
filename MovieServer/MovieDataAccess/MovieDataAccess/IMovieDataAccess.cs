namespace MovieDataAccess.MovieData
{
    public interface IMovieDataAccess
    {
        Task<T> getDataFromResponseObj<T>(string path);
    }
}