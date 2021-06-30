using AutoMapper;
using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using BoxTI.DirectTreasuryOperation.API.Models.Requests;

namespace BoxTI.DirectTreasuryOperation.API.Profiles
{
    public class RequestToOperationsAmount : Profile
    {
        public RequestToOperationsAmount()
        {
            CreateMap<CreateOperationAmountRequest, OperationsAmount>();
        }
    }
}
