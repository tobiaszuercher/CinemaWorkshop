using System;
using System.Collections.Generic;
using System.Data.Entity;

using Cinema.Model.Entity;

namespace Cinema.Entity
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<CinemaDbContext>
    {
        protected override void Seed(CinemaDbContext context)
        {           
            context.Movies.Add(new MovieEntity()
                {
                    Actors = new List<ActorEntity>()
                        {
                            new ActorEntity() { Firstname = "Leonardo", Lastname = "DiCaprio", Rolename = "Cobb" },
                            new ActorEntity() { Firstname = "Joseph", Lastname = "Gordon-Levitt", Rolename = "Arthur" }
                        },
                    ReleaseDate = new DateTime(2010, 1, 1),
                    Title = "Inception",
                    TmdbId = 27205
                });

            context.Movies.Add(new MovieEntity()
            {
                Actors = new List<ActorEntity>()
                        {
                            new ActorEntity() { Firstname = "Keanu", Lastname = "Reaves", Rolename = "Neo" },
                            new ActorEntity() { Firstname = "Laurence", Lastname = "Fishburne", Rolename = "Morpheus" }
                        },
                ReleaseDate = new DateTime(1999, 1, 3),
                Title = "The Matrix",
                TmdbId = 603
            });

            context.Movies.Add(new MovieEntity()
            {
                Actors = new List<ActorEntity>()
                        {
                            new ActorEntity() { Firstname = "Bruce", Lastname = "Willis", Rolename = "Older Joe" },
                            new ActorEntity() { Firstname = "Joseph", Lastname = "Gordon-Levitt", Rolename = "Joe" }
                        },
                ReleaseDate = new DateTime(2012, 09, 20),
                Title = "Looper",
                TmdbId = 603
            });

            context.SaveChanges();
        }
    }
}