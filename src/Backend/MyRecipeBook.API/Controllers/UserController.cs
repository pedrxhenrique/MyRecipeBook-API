using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyRecipeBook.Communication.Responses;

namespace MyRecipeBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterUserJson), StatusCodes.Status201Created)]
        public IActionResult Register()
        {
            return Created();
        }
    }
}
