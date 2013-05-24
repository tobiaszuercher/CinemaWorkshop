using System;

namespace Cinema.Model.Entity
{
    public class ShowEntity
    {
        public int Id { get; set; }
        public virtual MovieEntity MovieEntity { get; set; }

        public DateTime StartTime { get; set; }
    }
}