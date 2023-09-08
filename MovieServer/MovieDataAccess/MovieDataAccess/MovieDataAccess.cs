using System.Text.Json;

namespace MovieDataAccess.MovieData;

public class MovieDataAccess : IMovieDataAccess
{
    private static HttpClient client = new HttpClient();

    public async Task<T> getDataFromResponseObj<T>(string path)
    {
        var response = await client.GetAsync(path);
        var a = response.Content.ReadAsStringAsync();
        T jsonObj = JsonSerializer.Deserialize<T>(a.Result);
        return jsonObj;
    }
}
