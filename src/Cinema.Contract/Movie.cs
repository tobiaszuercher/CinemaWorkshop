using ServiceStack.ServiceHost;

namespace Cinema.Contract
{
    [Route("/movie")]
    [Route("/movie/{TmdbId}")]
    public class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Teaser { get; set; }
        public long TmdbId { get; set; }
        public string Cover { get; set; }
        public string Fanart { get; set; }
    }
}
