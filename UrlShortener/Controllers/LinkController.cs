using System;
using System.Threading.Tasks;
using Domain.ApiModel;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace UrlShortener.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinkController : Controller
    {
        private readonly ILinkService _linkService;

        public LinkController(ILinkService linkService)
        {
            if (linkService == null)
                throw new NotImplementedException(nameof(linkService));
            
            _linkService = linkService;
        }

        [HttpPost("save")]
        public async Task<IActionResult> Save(SaveRequest model)
        {
            // Identify which user is logged in / this can also be managed automatically by implementing JWT OAuth 2.0

            var isSaved = await _linkService.Save(1, model);
            if (isSaved)
                return Ok("Links saved succesfully");

            return BadRequest("Failed to save links");
        } 
    }
}