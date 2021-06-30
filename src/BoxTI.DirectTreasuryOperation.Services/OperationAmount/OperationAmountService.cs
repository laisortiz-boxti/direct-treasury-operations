using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using BoxTI.DirectTreasuryOperation.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoxTI.DirectTreasuryOperation.Services.OperationAmount
{
    public class OperationAmountService : IOperationAmountService
    {
        private readonly IDirectTreasuryOperationService _directTreasuryOperationService;
        private readonly IOperationAmountRepository _operationAmountRepository;

        public OperationAmountService(IDirectTreasuryOperationService directRepository, IOperationAmountRepository repository)
        {
            _directTreasuryOperationService = directRepository;
            _operationAmountRepository = repository;
        }

        public async Task AddAsync()
        {
            var response = _directTreasuryOperationService.GetAll();
            
            var data = response.Select(x => new OperationsAmount(x.OperationAmount, x.OperationDate, x.TitleMaturityDate));
            
            await _operationAmountRepository.AddRangeAsync(data);
        }

        public async Task AddAsync(OperationsAmount entity)
        {
            await _operationAmountRepository.AddAsync(entity);
        }

        public IEnumerable<OperationsAmount> GetAll()
        {
            return _operationAmountRepository.GetAll();
        }

        public async Task<OperationsAmount> GetAsync(string id)
        {
            return await _operationAmountRepository.GetAsync(x => x.Id == id);
        }

        public async Task DeleteAsync(string id)
        {
            await _operationAmountRepository.DeleteAsync(id);
        }

        public async Task UpdateAsync(OperationsAmount entity)
        {
            await _operationAmountRepository.UpdateAsync(entity);
        }
    }
}
