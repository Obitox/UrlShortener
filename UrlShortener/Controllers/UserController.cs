using System;
using System.Threading.Tasks;
using Domain.ApiModel;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace UrlShortener.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            if (userService == null)
                throw new NotImplementedException(nameof(IUserService));
                
            _userService = userService;
        }

        public IActionResult Index()
        {
            return Ok("Ok");
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authentication(AuthenticationRequest model)
        {
            var isAuthenticated = await _userService.Authenticate(model);

            if (isAuthenticated)
                return Ok("Authenticated");

            return BadRequest("Invalid username or password");
        }
    }
}