using ServiceStack.ServiceHost;

namespace Cinema.Contract
{
    [Route("/hello")]
    [Route("/hello/{Name}")]
    public class Hello
    {
        public string Name { get; set; }
    }
}