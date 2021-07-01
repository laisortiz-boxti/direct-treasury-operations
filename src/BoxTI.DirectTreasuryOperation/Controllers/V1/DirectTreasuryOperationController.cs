using AutoMapper;
using BoxTI.DirectTreasuryOperation.API.Cache;
using BoxTI.DirectTreasuryOperation.API.Client.ApiResponses;
using BoxTI.DirectTreasuryOperation.API.Client.Requests;
using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using BoxTI.DirectTreasuryOperation.API.Models.Responses;
using BoxTI.DirectTreasuryOperation.API.Routes;
using BoxTI.DirectTreasuryOperation.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoxTI.DirectTreasuryOperation.Controllers
{
    [ApiController]
    [Route(APIRoutes.Base)]
    public class DirectTreasuryOperationController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IDirectTreasuryOperationService _directTreasuryOperationService;

        public DirectTreasuryOperationController(IDirectTreasuryOperationService service, IMapper mapper)
        {
            _directTreasuryOperationService = service;
            _mapper = mapper;
        }

        [HttpPost(APIRoutes.DirectTreasuryOperationRoutes.CreateFromCsv)]
        public IActionResult Create()
        {
            _directTreasuryOperationService.GetCsvFile();
            return Ok(new ApiOkResponse());
        }

        [HttpPost(APIRoutes.DirectTreasuryOperationRoutes.Create)]
        public async Task<IActionResult> CreateOne([FromBody] CreateDirectTreasuryOperationRequest request)
        {
            var entity = _mapper.Map<DirectTreasuryOperations>(request);

            await _directTreasuryOperationService.Update(entity);
            return Ok(new ApiOkResponse());
        }

        [HttpGet(APIRoutes.DirectTreasuryOperationRoutes.GetAll)]
        [Cached(100)]
        public IActionResult GetAll()
        {
            var data = _directTreasuryOperationService.GetAll();
            var response = _mapper.Map<IEnumerable<DirectTreasuryOperationResponse>>(data);

            return Ok(new ApiOkResponse<IEnumerable<DirectTreasuryOperationResponse>>(response));
        }

        [HttpGet(APIRoutes.DirectTreasuryOperationRoutes.GetById)]
        public async Task<IActionResult> Get(string id)
        {
            var data = await _directTreasuryOperationService.Get(id);
            var response = _mapper.Map<DirectTreasuryOperationResponse>(data);
            
            return Ok(new ApiOkResponse<DirectTreasuryOperationResponse>(response));
        }

        [HttpDelete(BaseRoutes.DeleteById)]
        public async Task<IActionResult> Delete(string id)
        {
            await _directTreasuryOperationService.Delete(id);
            return Ok(new ApiOkResponse());
        }

        [HttpPut(APIRoutes.DirectTreasuryOperationRoutes.Update)]
        public async Task<IActionResult> Update([FromBody] CreateDirectTreasuryOperationRequest request)
        {
            var entity = _mapper.Map<DirectTreasuryOperations>(request);

            await _directTreasuryOperationService.Update(entity);
            return Ok(new ApiOkResponse());
        }
    }
}
