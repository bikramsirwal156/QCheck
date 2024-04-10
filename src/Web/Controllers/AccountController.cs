using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QCheck.Application.Authentication.Commands.LoginUser;

namespace QCheck.Web.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    [HttpPost("Login")]
    public async Task<IActionResult> LoginAsync(ISender sender, [FromBody] LoginCommand command)
    {
        var result = await sender.Send(command);
        if(result != null)
        {
            return Ok(result);
        }

        return Unauthorized();
    }

    [Authorize]
    [HttpGet("weatherForcase")]
    public  IActionResult GetUserAsync(ISender send)
    {
        return Ok("Hello");
    }
}
