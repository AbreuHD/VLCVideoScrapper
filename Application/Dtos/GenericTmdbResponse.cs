using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dtos
{
    public class GenericTmdbResponse
    {
        public long Page { get; set; }
        public ResultMovieResponse[] Results { get; set; }
        public long TotalPages { get; set; }
        public long TotalResults { get; set; }
    }
}
