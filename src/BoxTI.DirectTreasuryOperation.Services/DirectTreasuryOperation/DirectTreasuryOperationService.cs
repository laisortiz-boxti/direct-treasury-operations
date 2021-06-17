using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using BoxTI.DirectTreasuryOperation.Data.Interfaces;
using System.Collections.Generic;

namespace BoxTI.DirectTreasuryOperation.Services
{
    public class DirectTreasuryOperationService : IDirectTreasuryOperationService
    {
        private readonly IDirectTreasuryOperationRepository _directTreasuryOperationRepository;

        public IEnumerable<DirectTreasuryOperations> Get()
        {
            return null;
        }

        public void Add(DirectTreasuryOperations entity)
        {
            _directTreasuryOperationRepository.Add(entity);
        }
    }
}
