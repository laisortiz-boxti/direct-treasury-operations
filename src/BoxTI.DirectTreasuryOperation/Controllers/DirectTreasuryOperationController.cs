using BoxTI.DirectTreasuryOperation.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BoxTI.DirectTreasuryOperation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DirectTreasuryOperationController : ControllerBase
    {
        private readonly ILogger<DirectTreasuryOperationController> _logger;
        private readonly IDirectTreasuryOperationService _directTreasuryOperationService;

        public DirectTreasuryOperationController(ILogger<DirectTreasuryOperationController> logger)
        {
            _logger = logger;
        }

        public IActionResult Get()
        {

        }
    }
}
