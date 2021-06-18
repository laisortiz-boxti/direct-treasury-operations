using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using System.Collections.Generic;

namespace BoxTI.DirectTreasuryOperation.Services
{
    public interface IDirectTreasuryOperationService
    {
        void GetCsvFileAndSave();
        void Add(DirectTreasuryOperations entity);
        IEnumerable<DirectTreasuryOperations> All();
        DirectTreasuryOperations Get(string id);
        void Delete(string id);
    }
}
