using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using BoxTI.DirectTreasuryOperation.Data.Interfaces;
using System.Collections.Generic;

namespace BoxTI.DirectTreasuryOperation.Data.Repositories
{
    public class DirectTreasuryOperationRepository : IDirectTreasuryOperationRepository
    {
        private readonly DirectTreasuryContext _context;

        public DirectTreasuryOperationRepository(DirectTreasuryContext context)
        {
            _context = context;
        }

        public void Add(DirectTreasuryOperations entity)
        {
            _context.Add(entity);
        }

        public IEnumerable<DirectTreasuryOperations> Get()
        {
            return _context.Set<DirectTreasuryOperations>();
        }
    }
}
