using System;

namespace BoxTI.DirectTreasuryOperation.API.Client.Requests
{
    public class CreateDirectTreasuryOperationRequest
    {
        public int InvestorCode { get; set; }
        public DateTime OperationDate { get; set; }
        public string TitleType { get; set; }
        public DateTime TitleMaturityDate { get; set; }
        public double Quantity { get; set; }
        public decimal TitleAmount { get; set; }
        public decimal OperationAmount { get; set; }
    }
}
