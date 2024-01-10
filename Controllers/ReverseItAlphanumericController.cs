using Microsoft.AspNetCore.Mvc;

namespace MiniChallengeFiveToSeven_Endpoints.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class ReverseItAlphanumericController : ControllerBase
    {
        [HttpGet]
        [Route("EnterInAlphanumeric/{alphanumeric}")]
        public string ReverseIt(string alphanumeric){
            string reversed = "";
            for(int i = alphanumeric.Length - 1; i >= 0; i--){
                reversed += alphanumeric[i];
            }
            return $"You entered {alphanumeric}, reversed is {reversed}";
        }
    }
