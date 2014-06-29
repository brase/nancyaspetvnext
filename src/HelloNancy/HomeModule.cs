namespace WebApplication3
{
    using Nancy;

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => "Hello World from Nancy in ASP.Net vNext";
        }
    }
}