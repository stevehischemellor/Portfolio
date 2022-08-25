using Microsoft.AspNetCore.Mvc;

namespace PortfolioApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PictureController : ControllerBase
    {      

        private readonly ILogger<PictureController> _logger;

        public PictureController(ILogger<PictureController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPicture")]
        public IEnumerable<string> Get()
        {
            return null;
        }
    }
}