using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using BoxTI.DirectTreasuryOperation.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        private IEnumerable<(decimal amountDifference, DateTime initialOperationDate, DateTime finalOperationDate)> GetDirectTreasuryData()
        {
            return _directTreasuryOperationService.All().Select(x => (x.OperationAmount, x.OperationDate, x.TitleMaturityDate));
        }

        public void Add()
        {
            foreach (var (amountDifference, initialOperationDate, finalOperationDate) in GetDirectTreasuryData())
            {
                _operationAmountRepository.Add(new OperationsAmount(amountDifference, initialOperationDate, finalOperationDate));
            }
        }

        public void Add(OperationsAmount entity)
        {
            _operationAmountRepository.Add(entity);
        }
    }
}
