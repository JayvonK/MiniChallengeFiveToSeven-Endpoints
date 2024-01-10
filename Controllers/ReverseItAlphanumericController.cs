using Microsoft.AspNetCore.Mvc;
using MiniChallengeFiveToSeven_Endpoints.Services.ReverseItAlphanumeric;

namespace MiniChallengeFiveToSeven_Endpoints.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class ReverseItAlphanumericController : ControllerBase
    {
    private readonly IReverseItAlphanumericService _reverseItAlphanumericService;

    public ReverseItAlphanumericController(IReverseItAlphanumericService reverseItAlphanumericService)
        {
        _reverseItAlphanumericService = reverseItAlphanumericService;
    }

        [HttpGet]
        [Route("EnterInAlphanumeric/{alphanumeric}")]
        public string ReverseIt(string alphanumeric){
            return _reverseItAlphanumericService.ReverseIt(alphanumeric);
        }
    }
