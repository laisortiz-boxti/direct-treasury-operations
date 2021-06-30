using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoxTI.DirectTreasuryOperation.Services.OperationAmount
{
    public interface IOperationAmountService
    {
        Task AddAsync();
        Task AddAsync(OperationsAmount entity);

        IEnumerable<OperationsAmount> GetAll();
        Task<OperationsAmount> GetAsync(string id);

        Task DeleteAsync(string id);
        Task UpdateAsync(OperationsAmount entity);
    }
}
