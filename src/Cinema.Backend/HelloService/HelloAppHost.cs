using ServiceStack.WebHost.Endpoints;

namespace Cinema.Backend.HelloService
{
    public class HelloAppHost : AppHostBase
    {
        // Tell Service Stack the name of your application and where to find your web services
        public HelloAppHost()
            : base("Hello Web Services", typeof(HelloService).Assembly)
        {
        }

        public override void Configure(Funq.Container container)
        {
            ////register any dependencies your services use, e.g:
            ////container.Register<ICacheClient>(new MemoryCacheClient());
        }
    }
}