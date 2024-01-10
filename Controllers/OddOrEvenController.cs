using Microsoft.AspNetCore.Mvc;

namespace MiniChallengeFiveToSeven_Endpoints.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class OddOrEvenController : ControllerBase
    {
        [HttpGet]
        [Route("EnterANumber/{number}")]
        public string OddOrEven(string number){
            
        }
    }
