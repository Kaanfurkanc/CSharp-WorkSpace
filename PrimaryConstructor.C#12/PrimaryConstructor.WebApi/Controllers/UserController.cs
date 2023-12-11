using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrimaryConstructor.WebApi.Core.Interfaces;

namespace PrimaryConstructor.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserService userService, ILogger<UserController> logger) 
        : ControllerBase
    {

        [HttpGet]
        public IActionResult GetAllUsers()
        {

            var users = userService.GetAllUsers();
            if (users == null)
            {
                logger.LogInformation("There is not any user!");
                return NoContent();
            }
            return Ok(users);
        }
    }
}
