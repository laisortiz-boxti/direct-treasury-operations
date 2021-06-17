using System;

namespace BoxTI.DirectTreasuryOperation.API.Models.Entities
{
    public class OperationAmounts
    {
        public decimal AmountDifference { get; set; }
        public DateTime InitialOperationDate { get; set; }
        public DateTime FinalOperationDate { get; set; }
    }
}
