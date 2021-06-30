using BoxTI.DirectTreasuryOperation.API.Client.Exceptions;
using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using BoxTI.DirectTreasuryOperation.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BoxTI.DirectTreasuryOperation.Data.Repositories
{
    public class OperationAmountRepository : IOperationAmountRepository
    {
        private readonly DirectTreasuryContext _context;

        public OperationAmountRepository(DirectTreasuryContext context)
        {
            _context = context;
        }

        public async Task AddAsync(OperationsAmount entity)
        {
            await _context.OperationsAmount.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task AddRangeAsync(IEnumerable<OperationsAmount> entities)
        {
            await _context.OperationsAmount.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }

        public async Task<OperationsAmount> GetAsync(Expression<Func<OperationsAmount, bool>> predicate)
        {
            return await _context.OperationsAmount.FirstOrDefaultAsync(predicate) ?? throw new NotFoundException("Not found");
        }

        public IEnumerable<OperationsAmount> GetAll()
        {
            return _context.OperationsAmount ?? throw new Exception("Data base is empty.");
        }

        public async Task DeleteAsync(string id)
        {
            var entity = await GetAsync(x => x.Id == id);
            _context.OperationsAmount.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(OperationsAmount entityToUpdate)
        {
            _context.OperationsAmount.Update(entityToUpdate);
            await _context.SaveChangesAsync();
        }
    }
}
