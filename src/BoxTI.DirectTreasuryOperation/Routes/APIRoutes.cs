namespace BoxTI.DirectTreasuryOperation.API.Routes
{
    public static class APIRoutes 
    {
        private const string CurrentVersion = "v1/";
        public const string Base = "api/" + CurrentVersion + "[controller]";

        public class DirectTreasuryOperationRoutes : BaseRoutes
        {
            public const string CreateFromCsv = "create/csv";
        }
        
        public class OperationsAmountRoutes : BaseRoutes
        {
            public const string CreateFromDb = "create/db";
        }
    }
}
