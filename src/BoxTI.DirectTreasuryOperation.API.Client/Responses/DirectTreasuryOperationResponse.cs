namespace BoxTI.DirectTreasuryOperation.API.Models.Responses
{
    public class DirectTreasuryOperationResponse
    {
        public string TitleType { get; set; }
        public double Quantity { get; set; }
        public decimal TitleAmount { get; set; }
        public decimal OperationAmount { get; set; }
    }
}
