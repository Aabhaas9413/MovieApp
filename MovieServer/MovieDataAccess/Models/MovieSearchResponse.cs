using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDataAccess.Models
{
    public class MovieSearchResponse
    {
        public string Response { get; set; }
        public List<MovieSearch> Search { get; set; }
        public string totalResults { get; set; }

    }
}
