using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BoxTI.DirectTreasuryOperation.Data.Interfaces
{
    public interface IDirectTreasuryRepository
    {
        Task AddAsync(DirectTreasuryOperations entity);
        Task AddRangeAsync(IList<DirectTreasuryOperations> entities);
        Task AddRangeAsync(IEnumerable<DirectTreasuryOperations> entities);

        Task<DirectTreasuryOperations> GetAsync(Expression<Func<DirectTreasuryOperations, bool>> predicate);
        IEnumerable<DirectTreasuryOperations> GetAll();

        Task UpdateAsync(DirectTreasuryOperations entityToUpdate);
        
        Task DeleteAsync(string id);
    }
}