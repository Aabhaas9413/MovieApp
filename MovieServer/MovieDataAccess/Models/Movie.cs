
namespace MovieDataAccess.Models;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Year { get; set; }
    public string Rated { get; set; }

    public string Released { get; set; }
    public string Runtime { get; set; }
    public string Genre { get; set; }
    public string Actors { get; set; }
    public string Director { get; set; }
    public string Language { get; set; }
    public string Country { get; set; }
    public string Awards { get; set; }
    public string Poster { get; set; }
    public string plot { get; set; }
    public List<Rating> Ratings { get; set; }
    public string IMDbRating { get; set; }
    public string IMDbVotes { get; set; }
    public string Type { get; set; }
}
