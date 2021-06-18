using BoxTI.DirectTreasuryOperation.Services.OperationAmount;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BoxTI.DirectTreasuryOperation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationAmountController : ControllerBase
    {
        private readonly IOperationAmountService _operationAmountService;

        public OperationAmountController(IOperationAmountService service)
        {
            _operationAmountService = service;
        }

        [HttpPost]
        public IActionResult Save()
        {
            _operationAmountService.Add();
            return Ok();
        }

        // GET api/<OperationAmountController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // PUT api/<OperationAmountController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OperationAmountController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
