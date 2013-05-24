using System.Linq;
using System.Net;

using Cinema.Contract;
using Cinema.Entity;
using Cinema.Model.Entity;

using ServiceStack.Common.Extensions;
using ServiceStack.Common.Web;
using ServiceStack.ServiceInterface;

using System.Data.Entity;

namespace Cinema.Backend.MovieService
{
    public class MovieService : Service
    {
        public IDbContextFactory ContextFactory { get; set; } // will be auto-wired by IOC

        public object Get(Movie request)
        {
            using (var context = ContextFactory.CreateDbContext())
            {
                if (request.TmdbId != default(long))
                {
                    var foundMovie = context.Movies.First(m => m.TmdbId == request.TmdbId);

                    if (foundMovie != default(MovieEntity))
                    {
                        return foundMovie;
                    }

                    return new HttpResult(HttpStatusCode.NotFound);
                }

                var result = context.Movies.Include(m => m.Actors);

                return result;
            }
        }
    }
}