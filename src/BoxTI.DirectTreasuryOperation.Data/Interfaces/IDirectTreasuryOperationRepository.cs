using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using System.Collections.Generic;

namespace BoxTI.DirectTreasuryOperation.Data.Interfaces
{
    public interface IDirectTreasuryOperationRepository
    {
        void Add(DirectTreasuryOperations entity);
        IEnumerable<DirectTreasuryOperations> Get();
    }
}
