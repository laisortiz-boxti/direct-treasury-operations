using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using BoxTI.DirectTreasuryOperation.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BoxTI.DirectTreasuryOperation.Data.Repositories
{
    public class DirectTreasuryRepository : IDirectTreasuryRepository
    {
        private readonly DirectTreasuryContext _context;

        public DirectTreasuryRepository(DirectTreasuryContext context)
        {
            _context = context;
        }

        public void Add(DirectTreasuryOperations entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public DirectTreasuryOperations Get(Func<DirectTreasuryOperations, bool> predicate)
        {
            return _context.DirectTreasuryOperations.FirstOrDefault(predicate);
        }

        public IEnumerable<DirectTreasuryOperations> All()
        {
            return _context.DirectTreasuryOperations.OrderBy(x => x.OperationAmount);
        }

        public void Delete(DirectTreasuryOperations entity)
        {
            _context.DirectTreasuryOperations.Remove(entity);
            _context.SaveChanges();
        }
    }
}
