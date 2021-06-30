using BoxTI.DirectTreasuryOperation.API.Client.Requests;
using FluentValidation;

namespace BoxTI.DirectTreasuryOperation.API.FluentValidation
{
    public class CreateDirectTreasuryOperationRequestValidator : AbstractValidator<CreateDirectTreasuryOperationRequest>
    {
        public CreateDirectTreasuryOperationRequestValidator()
        {
            RuleFor(x => x.InvestorCode).NotNull();

            RuleFor(x => x.OperationAmount).NotNull();

            RuleFor(x => x.Quantity).NotNull();

            RuleFor(x => x.TitleAmount).NotNull();
            
            RuleFor(x => x.OperationDate)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.TitleMaturityDate)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.TitleType)
                .NotNull()
                .NotEmpty();
        }
    }
}
