using Cinema.Contract;

using ServiceStack.ServiceInterface;

namespace Cinema.Backend.HelloService
{
    public class HelloService : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = "Hello, " + request.Name };
        }
    } 
}