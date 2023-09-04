using System.Text.Json;

namespace MovieDataAccess.MovieData;

public static class MovieDataAccess
{
    private static HttpClient client = new HttpClient();

    public static async Task<T?> getDataFromResponseObj<T>(string path)
    {
        var response = await client.GetAsync(path);
        var a = response.Content.ReadAsStringAsync();
        T? jsonObj = JsonSerializer.Deserialize<T>(a.Result);
        return jsonObj;
    }
}
