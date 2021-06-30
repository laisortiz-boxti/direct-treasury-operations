using Newtonsoft.Json;

namespace BoxTI.DirectTreasuryOperation.API.Client.Responses
{
    public class ExceptionResponse
    {
        public string Message { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
