using System.Data.Entity;

using Cinema.Model.Entity;

namespace Cinema.Entity
{
    public class CinemaDbContext : DbContext, ICinemaDbContext
    {
        public DbSet<MovieEntity> Movies { get; set; }
        public DbSet<ActorEntity> Actors { get; set; }
        public DbSet<ShowEntity> Shows { get; set; }

        public CinemaDbContext()
            : base(@"data source=.\SQLEXPRESS;Initial Catalog=CinemaWorkshop;integrated security=True;")
        {   
        }
    }
}