using System.Web.Http;

namespace HelloWorldApi.Controllers
{
    public class GreetingController : ApiController
    {
        [HttpGet]
        public string getGreeting()
        {
            string greeting = "Hello, World!";
            return greeting;
        }
    }
}
