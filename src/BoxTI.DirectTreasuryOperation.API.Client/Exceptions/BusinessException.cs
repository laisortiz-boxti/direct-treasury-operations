namespace BoxTI.DirectTreasuryOperation.API.Client.Exceptions
{
    public class BusinessException : BaseException
    {
        public BusinessException(string message, params object[] args)
          : base(message, args)
        {
        }
    }
}
