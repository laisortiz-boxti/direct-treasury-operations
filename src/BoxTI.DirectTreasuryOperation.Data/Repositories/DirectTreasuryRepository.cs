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
    public class DirectTreasuryRepository : IDirectTreasuryRepository
    {
        private readonly DirectTreasuryContext _context;

        public DirectTreasuryRepository(DirectTreasuryContext context)
        {
            _context = context;
        }

        public async Task AddAsync(DirectTreasuryOperations entity)
        {
            await _context.DirectTreasuryOperations.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task AddRangeAsync(IList<DirectTreasuryOperations> entities)
        {
            await _context.DirectTreasuryOperations.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }

        public async Task AddRangeAsync(IEnumerable<DirectTreasuryOperations> entities)
        {
            await _context.DirectTreasuryOperations.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }

        public async Task<DirectTreasuryOperations> GetAsync(Expression<Func<DirectTreasuryOperations, bool>> predicate)
        {
            return await _context.DirectTreasuryOperations.FirstOrDefaultAsync(predicate) ?? throw new NotFoundException("Entity not founded.");
        }

        public IEnumerable<DirectTreasuryOperations> GetAll()
        {
            return _context.DirectTreasuryOperations;
        }

        public async Task UpdateAsync(DirectTreasuryOperations entityToUpdate)
        {
            _context.DirectTreasuryOperations.Update(entityToUpdate);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            var entity = await GetAsync(x => x.Id == id);
            _context.DirectTreasuryOperations.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
