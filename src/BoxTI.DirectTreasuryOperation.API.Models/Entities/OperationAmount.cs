﻿using System;

namespace BoxTI.DirectTreasuryOperation.API.Models.Entities
{
    public class OperationsAmount
    {
        public decimal AmountDifference { get; set; }
        public DateTime InitialOperationDate { get; set; }
        public DateTime FinalOperationDate { get; set; }

        public OperationsAmount(decimal amountDifference, DateTime initialOperationDate, DateTime finalOperationDate)
        {
            AmountDifference = amountDifference;
            InitialOperationDate = initialOperationDate;
            FinalOperationDate = finalOperationDate;
        }

        public OperationsAmount()
        {

        }
    }
}
