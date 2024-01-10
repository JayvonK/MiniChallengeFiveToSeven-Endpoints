using Microsoft.AspNetCore.Mvc;
using MiniChallengeFiveToSeven_Endpoints.Services.ReverseItNumbers;

namespace MiniChallengeFiveToSeven_Endpoints.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class ReverseItNumbersController : ControllerBase
    {
    private readonly IReverseItNumbersService _reverseItNumbersService;

    public ReverseItNumbersController(IReverseItNumbersService reverseItNumbersService)
        {
        _reverseItNumbersService = reverseItNumbersService;
    }
        
        [HttpGet]
        [Route("EnterNumber/{number}")]
        public string ReversedNumber(string number){
            return _reverseItNumbersService.ReversedNumber(number);
        }
    }
