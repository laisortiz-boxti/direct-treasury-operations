using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Globalization;

namespace BoxTI.DirectTreasuryOperation.Services.Extensions
{
    public static class ObjectExtensions
    {
        public static string ToJson<T>(this T source, Formatting? formatting = null, JsonSerializerSettings settings = null)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            var formattingInternal = formatting ?? Formatting.None;
            var settingsInternal = settings ?? new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Converters = { new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal } }
            };

            var json = JsonConvert.SerializeObject(source, formattingInternal, settingsInternal);

            return json;
        }
    }
}
