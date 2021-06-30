using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BoxTI.DirectTreasuryOperation.Data.Interfaces
{
    public interface IOperationAmountRepository
    {
        Task AddAsync(OperationsAmount entity);
        Task AddRangeAsync(IEnumerable<OperationsAmount> entities);

        Task<OperationsAmount> GetAsync(Expression<Func<OperationsAmount, bool>> predicate);
        IEnumerable<OperationsAmount> GetAll();

        Task DeleteAsync(string id);
        Task UpdateAsync(OperationsAmount entityToUpdate);
    }
}
