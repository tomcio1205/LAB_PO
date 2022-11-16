using Microsoft.AspNetCore.Mvc;
using WebApplication3.Services.LAB3;


namespace WebApplication3.Controllers.LAB3
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SomeController : ControllerBase
    {
        [HttpGet]
        public string CallMethod()
        {
            var someInstance = new SomeClass();
            return someInstance.Print(null);
        }

    }
}
