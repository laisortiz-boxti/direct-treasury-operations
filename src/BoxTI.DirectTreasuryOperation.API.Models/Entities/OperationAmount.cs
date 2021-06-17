using System;

namespace BoxTI.DirectTreasuryOperation.API.Models.Entities
{
    public class OperationAmount
    {
        public decimal AmountDifference { get; set; }
        public DateTime IniitalOperationDate { get; set; }
        public DateTime FinalOperationDate { get; set; }
    }
}
