using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BoxTI.DirectTreasuryOperation.API.Models.Entities
{
    public class DirectTreasuryOperations
    {
        [JsonIgnore]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public int InvestorCode { get; set; }
        public DateTime OperationDate { get; set; }
        public string TitleType { get; set; }
        public DateTime TitleMaturityDate { get; set; }
        public double Quantity { get; set; }
        public decimal TitleAmount { get; set; }
        public decimal OperationAmount { get; set; }

        public DirectTreasuryOperations() 
        {
            
        }

        public DirectTreasuryOperations(
            int code,
            DateTime operationDate,
            string titleType,
            DateTime titleMaturityDate,
            double quantity,
            decimal titleAmount,
            decimal operationAmount
        )
        {
            InvestorCode = code;
            OperationDate = operationDate;
            TitleType = titleType;
            TitleMaturityDate = titleMaturityDate;
            Quantity = quantity;
            TitleAmount = titleAmount;
            OperationAmount = operationAmount;
        }
    }
}
