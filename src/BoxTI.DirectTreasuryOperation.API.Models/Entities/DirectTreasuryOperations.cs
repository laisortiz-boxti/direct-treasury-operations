using System;

namespace BoxTI.DirectTreasuryOperation.API.Models.Entities
{
    public class DirectTreasuryOperations
    {
        public int Id { get; set; }
        public int InvestorCode { get; set; }
        public DateTime OperationDate { get; set; }
        public string BondType { get; set; }
        public DateTime BondMaturityDate { get; set; }
        public double Quantity { get; set; }
        public decimal BondAmount { get; set; }
        public decimal OperationAmount { get; set; }
    }
}
