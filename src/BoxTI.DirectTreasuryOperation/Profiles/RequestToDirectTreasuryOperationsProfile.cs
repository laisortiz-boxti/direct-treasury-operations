using AutoMapper;
using BoxTI.DirectTreasuryOperation.API.Client.Requests;
using BoxTI.DirectTreasuryOperation.API.Models.Entities;

namespace BoxTI.DirectTreasuryOperation.API.Profiles
{
    public class RequestToDirectTreasuryOperationsProfile : Profile
    {
        public RequestToDirectTreasuryOperationsProfile()
        {
            CreateMap<CreateDirectTreasuryOperationRequest, DirectTreasuryOperations > ();
        }
    }
}
