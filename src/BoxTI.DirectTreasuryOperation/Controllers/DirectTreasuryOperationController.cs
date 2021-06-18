using BoxTI.DirectTreasuryOperation.API.Models.Entities;
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

        public DirectTreasuryOperationController(ILogger<DirectTreasuryOperationController> logger, IDirectTreasuryOperationService service)
        {
            _logger = logger;
            _directTreasuryOperationService = service;
        }

        [HttpPost]
        public IActionResult Save()
        {
            _directTreasuryOperationService.GetCsvFileAndSave();
            return Ok(new { message = "Success" });
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _directTreasuryOperationService.Delete(id);
        }
    }
}
