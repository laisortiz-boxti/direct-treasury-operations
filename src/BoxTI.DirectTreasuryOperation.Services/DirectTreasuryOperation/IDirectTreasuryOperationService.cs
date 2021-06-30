using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoxTI.DirectTreasuryOperation.Services
{
    public interface IDirectTreasuryOperationService
    {
        void GetCsvFile();
        Task Add(DirectTreasuryOperations entity);
        Task Update(DirectTreasuryOperations entity);

        IEnumerable<DirectTreasuryOperations> GetAll();
        Task<DirectTreasuryOperations> Get(string id);

        Task Delete(string id);
    }
}
