using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Model
{
    public class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Teaser { get; set; }
        public int TmdbId { get; set; }
        public string Cover { get; set; }
        public string Fanart { get; set; }
    }
}
