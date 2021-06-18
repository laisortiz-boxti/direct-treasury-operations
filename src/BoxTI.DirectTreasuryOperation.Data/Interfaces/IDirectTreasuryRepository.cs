using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using System;
using System.Collections.Generic;

namespace BoxTI.DirectTreasuryOperation.Data.Interfaces
{
    public interface IDirectTreasuryRepository
    {
        void Add(DirectTreasuryOperations entity);
        DirectTreasuryOperations Get(Func<DirectTreasuryOperations, bool> predicate);
        IEnumerable<DirectTreasuryOperations> All();
        void Delete(DirectTreasuryOperations entity);
    }
}