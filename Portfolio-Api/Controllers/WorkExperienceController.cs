using Microsoft.AspNetCore.Mvc;
using PortfolioApi.Models;

namespace PortfolioApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkExperienceController : ControllerBase
    {
        private readonly ILogger<WorkExperienceController> _logger;

        public WorkExperienceController(ILogger<WorkExperienceController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "WorkExperience")]
        public IEnumerable<WorkExperience> Get()
        {
            return new List<WorkExperience>();
        }
    }
}
