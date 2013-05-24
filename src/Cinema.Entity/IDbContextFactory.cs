namespace Cinema.Entity
{
    public interface IDbContextFactory
    {
        ICinemaDbContext CreateDbContext();
    }
}