using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BoxTI.DirectTreasuryOperation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DirectTreasuryOperationController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<DirectTreasuryOperationController> _logger;

        public DirectTreasuryOperationController(ILogger<DirectTreasuryOperationController> logger)
        {
            _logger = logger;
        }
    }
}
