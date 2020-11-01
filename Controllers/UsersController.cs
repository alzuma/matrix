using System.Threading.Tasks;
using Matrix.Controllers.Exceptions;
using Matrix.Controllers.Models;
using Matrix.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Matrix.Controllers
{
    public class UsersController : BaseController
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<ActionResult<AuthenticateResponse>> Authenticate([FromBody] AuthenticateModel model)
        {
            try
            {
                var user = await _userService.Authenticate(model.Username, model.Password);
                return Ok(new AuthenticateResponse {Token = user.Token});
            }
            catch (UserOrPasswordException e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}