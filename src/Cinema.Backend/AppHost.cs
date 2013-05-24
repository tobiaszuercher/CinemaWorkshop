using Cinema.Entity;

using ServiceStack.WebHost.Endpoints;

namespace Cinema.Backend
{
    public class AppHost : AppHostBase
    {
        public AppHost()
            : base("Web Services for Cinema Workshop", typeof(HelloService.HelloService).Assembly)
        {
        }

        public override void Configure(Funq.Container container)
        {
            //container.RegisterAutoWired<DbContextFactory>();
            container.Register<IDbContextFactory>(new DbContextFactory());
        }
    }
}