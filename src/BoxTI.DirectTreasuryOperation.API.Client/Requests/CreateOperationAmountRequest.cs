﻿using System;

namespace BoxTI.DirectTreasuryOperation.API.Models.Requests
{
    public class CreateOperationAmountRequest
    {
        public decimal AmountDifference { get; set; }
        public DateTime InitialOperationDate { get; set; }
        public DateTime FinalOperationDate { get; set; }
    }
}
