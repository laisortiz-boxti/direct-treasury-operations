using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using BoxTI.DirectTreasuryOperation.Data.Interfaces;

namespace BoxTI.DirectTreasuryOperation.Services.OperationAmount
{
    public class OperationAmountService : IOperationAmountService
    {
        private readonly IOperationAmountRepository _operationAmountRepository;

        public void Add(OperationAmounts entity)
        {
            _operationAmountRepository.Add(entity);
        }
    }
}
