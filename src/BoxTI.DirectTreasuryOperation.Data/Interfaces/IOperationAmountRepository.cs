using BoxTI.DirectTreasuryOperation.API.Models.Entities;

namespace BoxTI.DirectTreasuryOperation.Data.Interfaces
{
    public interface IOperationAmountRepository
    {
        void Add(OperationsAmount entity);
    }
}
