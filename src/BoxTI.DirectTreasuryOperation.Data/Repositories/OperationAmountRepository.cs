using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using BoxTI.DirectTreasuryOperation.Data.Interfaces;

namespace BoxTI.DirectTreasuryOperation.Data.Repositories
{
    public class OperationAmountRepository : IOperationAmountRepository
    {
        private readonly DirectTreasuryContext _context;

        public OperationAmountRepository(DirectTreasuryContext context)
        {
            _context = context;
        }

        public void Add(OperationsAmount entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }
    }
}
