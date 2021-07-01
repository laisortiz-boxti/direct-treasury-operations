using AutoMapper;
using BoxTI.DirectTreasuryOperation.API.Cache;
using BoxTI.DirectTreasuryOperation.API.Client.ApiResponses;
using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using BoxTI.DirectTreasuryOperation.API.Models.Requests;
using BoxTI.DirectTreasuryOperation.API.Routes;
using BoxTI.DirectTreasuryOperation.Services.OperationAmount;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoxTI.DirectTreasuryOperation.API.Controllers
{
    [ApiController]
    [Route(APIRoutes.Base)]
    public class OperationAmountController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IOperationAmountService _operationAmountService;

        public OperationAmountController(IOperationAmountService service, IMapper mapper)
        {
            _operationAmountService = service;
            _mapper = mapper;
        }

        [HttpPost(APIRoutes.OperationsAmountRoutes.Create)]
        public async Task<IActionResult> Create([FromBody] CreateOperationAmountRequest request)
        {
            var entity = _mapper.Map<OperationsAmount>(request);
            await _operationAmountService.AddAsync(entity);

            return Ok(new ApiOkResponse());
        }

        [HttpPost(APIRoutes.OperationsAmountRoutes.CreateFromDb)]
        public async Task<IActionResult> CreateFromDb()
        {
            await _operationAmountService.AddAsync();
            return Ok(new ApiOkResponse());
        }

        [HttpGet(APIRoutes.OperationsAmountRoutes.GetAll)]
        [Cached(60)]
        public IActionResult GetAll()
        {
            var entities = _operationAmountService.GetAll();
            return Ok(new ApiOkResponse<IEnumerable<OperationsAmount>>(entities));
        }

        [HttpGet(APIRoutes.OperationsAmountRoutes.GetById)]
        public async Task<IActionResult> Get(string id)
        {
            var entity = await _operationAmountService.GetAsync(id);

            return Ok(new ApiOkResponse<OperationsAmount>(entity));
        }

        [HttpPut(APIRoutes.OperationsAmountRoutes.Update)]
        public async Task<IActionResult> Put([FromBody] CreateOperationAmountRequest request)
        {
            var entity = _mapper.Map<OperationsAmount>(request);
            await _operationAmountService.UpdateAsync(entity);

            return Ok(new ApiOkResponse());
        }

        [HttpDelete(APIRoutes.OperationsAmountRoutes.DeleteById)]
        public async Task<IActionResult> Delete(string id)
        {
            await _operationAmountService.DeleteAsync(id);
            return Ok(new ApiOkResponse());
        }
    }
}
