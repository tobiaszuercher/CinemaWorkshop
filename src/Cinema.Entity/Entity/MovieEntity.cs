using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Model.Entity
{
    public class MovieEntity
    {
        [Key]
        public int      TmdbId      { get; set; }
        public string   Title       { get; set; }
        public DateTime ReleaseDate { get; set; }

        public virtual ICollection<ActorEntity> Actors { get; set; }
    }
}
