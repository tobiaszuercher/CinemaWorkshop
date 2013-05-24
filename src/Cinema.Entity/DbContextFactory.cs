namespace Cinema.Entity
{
    public class DbContextFactory : IDbContextFactory
    {
        public ICinemaDbContext CreateDbContext()
        {
            return new CinemaDbContext();
        }
    }
}