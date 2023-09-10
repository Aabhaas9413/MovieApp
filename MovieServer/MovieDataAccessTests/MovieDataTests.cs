using Microsoft.Extensions.Configuration;
using MovieDataAccess.Models;
using MovieDataAccess.MovieData;

namespace MovieDataAccessTests
{
    public class MovieDataTests
    {
        Mock<IConfiguration> config = new();

        [Fact]
        public async Task TestForMovieSearchListAsync()
        {
            //Arrange
            var _dataAccess = new Mock<IDataAccess>();
            var mock = new MovieSearchResponse() { Response = "true", Search = new List<MovieSearch>(), totalResults = "10"};
            _dataAccess.Setup(s => s.getDataFromResponseObj<MovieSearchResponse>(It.IsAny<string>())).ReturnsAsync(mock);

            //Act
            var movieData = new MovieData(config.Object, _dataAccess.Object);
            var res = await movieData.GetMovieListByTitle("harry", 1);

            //Assert
            Assert.Equal(res.totalResults, mock.totalResults);

        }
        [Fact]
        public async Task TestForMovieSearchListExceptionAsync()
        {
            //Arrange
            var _dataAccess = new Mock<IDataAccess>();
            _dataAccess.Setup(s => s.getDataFromResponseObj<MovieSearchResponse>(It.IsAny<string>())).Throws(new NotSupportedException());

            //Act
            var movieData = new MovieData(config.Object, _dataAccess.Object);

            //Assert
            await Assert.ThrowsAsync<NotSupportedException>(() => movieData.GetMovieListByTitle("harry", 1));

        }

        [Fact]
        public async Task TestForMovieSearchByTitleAsync()
        {
            //Arrange
            var _dataAccess = new Mock<IDataAccess>();
            var mock = new Movie() { Title = It.IsAny<string>(), Poster = It.IsAny<string>() };
            _dataAccess.Setup(s => s.getDataFromResponseObj<Movie>(It.IsAny<string>())).ReturnsAsync(mock);

            //Act
            var movieData = new MovieData(config.Object, _dataAccess.Object);
            var res = await movieData.GetMovieByTitle(It.IsAny<string>());

            //Assert
            Assert.Equal(res.Title, mock.Title);

        }

        [Fact]
        public async Task TestForMovieSearchByIMDbIDAsync()
        {
            //Arrange
            var _dataAccess = new Mock<IDataAccess>();
            var mock = new Movie() { Title = It.IsAny<string>(), Poster = It.IsAny<string>() };
            _dataAccess.Setup(s => s.getDataFromResponseObj<Movie>(It.IsAny<string>())).ReturnsAsync(mock);

            //Act
            var movieData = new MovieData(config.Object, _dataAccess.Object);
            var res = await movieData.GetMovieByIMDbId(It.IsAny<string>());

            //Assert
            Assert.Equal(res.Title, mock.Title);

        }
    }
}