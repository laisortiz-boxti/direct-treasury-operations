using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using BoxTI.DirectTreasuryOperation.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxTI.DirectTreasuryOperation.Data.Repositories
{
    class OperationAmountRepository : IOperationAmountRepository
    {
        private readonly DirectTreasuryContext _context;

        public OperationAmountRepository(DirectTreasuryContext context)
        {
            _context = context;
        }

        public void Add(OperationAmounts entity)
        {
            _context.Add(entity);
        }
    }
}
