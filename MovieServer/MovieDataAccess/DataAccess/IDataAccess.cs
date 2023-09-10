namespace MovieDataAccess.MovieData
{
    public interface IDataAccess
    {
        Task<T> getDataFromResponseObj<T>(string path);
    }
}