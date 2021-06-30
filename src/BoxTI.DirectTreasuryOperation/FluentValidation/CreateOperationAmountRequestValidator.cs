using BoxTI.DirectTreasuryOperation.API.Models.Requests;
using FluentValidation;

namespace BoxTI.DirectTreasuryOperation.API.FluentValidation
{
    public class CreateOperationAmountRequestValidator : AbstractValidator<CreateOperationAmountRequest>
    {
        public CreateOperationAmountRequestValidator()
        {
            RuleFor(x => x.AmountDifference).NotNull();

            RuleFor(x => x.InitialOperationDate)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.FinalOperationDate)
                .NotEmpty()
                .NotNull();
        }
    }
}
