using Microsoft.AspNetCore.Mvc;

namespace api_kancel.Controller.Administration
{
    [ApiController]
    [Route("[controller]")]
    public class ApplicationUserController : ControllerBase
    {
        public ApplicationUserController()
        {
            
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login()
        {
            return Ok();
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register()
        {
            return Ok();
        }

        [HttpPut("updatePassword")]
        public async Task<ActionResult> UpdatePassword()
        {
            return Ok();
        }
    }
}
