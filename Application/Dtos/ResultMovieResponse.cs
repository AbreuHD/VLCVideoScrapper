using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dtos
{
    public class ResultMovieResponse
    {
        public string backdrop_path { get; set; }
        public string original_title { get; set; }
        public string overview { get; set; }
        public string poster_path { get; set; }
        public DateTimeOffset release_date { get; set; }
        public string title { get; set; }
        public string original_name { get; set; }
        public string name { get; set; }
    }
}
