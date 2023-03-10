using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoutingWebAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [Route("home/name/{name}/location/{location}")]                     //Passing values dynamically
        public string GetName(string name, string location)
        {
            return $"Your name is {name}\nYou are from {location}";
        }

        [Route("home/personal")]                                             //Using multiple routes to access single resource
        [Route("home/age")]                                                //Passing values using queryString(?)
        public string GetAge(int age, string gender)
        {
            return $"Your age is {age.ToString()}\nYour gender is {gender}";
        }
    }
}
