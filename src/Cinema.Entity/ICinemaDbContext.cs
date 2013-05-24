using System;
using System.Data.Entity;

using Cinema.Model.Entity;

namespace Cinema.Entity
{
    public interface ICinemaDbContext : IDisposable
    {
        DbSet<MovieEntity> Movies { get; set; }
        DbSet<ActorEntity> Actors { get; set; }
        DbSet<ShowEntity> Shows { get; set; }
    }
}