using AutoMapper;
using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using BoxTI.DirectTreasuryOperation.API.Models.Responses;

namespace BoxTI.DirectTreasuryOperation.API.Profiles
{
    public class DirectTreasuryOperationsProfile : Profile
    {
        public DirectTreasuryOperationsProfile()
        {
            CreateMap<DirectTreasuryOperations, DirectTreasuryOperationResponse>();
        }
    }
}
