using Microsoft.Extensions.DependencyInjection;
using System;
using FluentValidation.AspNetCore;

namespace BoxTI.DirectTreasuryOperation.API.Configurations
{
    public static class MvcConfiguration
    {
        public static void AddMvcConfiguration(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddMvc(options =>
            {
                //options.Filters.Add<ValidationFilterAttribute>();
            })
            .AddFluentValidation(options =>
            {
                options.RegisterValidatorsFromAssemblyContaining<Startup>();
            });
            //.AddNewtonsoftJson(options =>
            //{
            //    var settings = new JsonSerializerSettings
            //    {
            //        NullValueHandling = NullValueHandling.Ignore,
            //        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            //        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            //        DateFormatHandling = DateFormatHandling.IsoDateFormat,
            //        ContractResolver = new CamelCasePropertyNamesContractResolver(),
            //        Converters = { new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal } }
            //    };

            //    options.SerializerSettings.NullValueHandling = settings.NullValueHandling;
            //    options.SerializerSettings.ReferenceLoopHandling = settings.ReferenceLoopHandling;
            //    options.SerializerSettings.DateFormatHandling = settings.DateFormatHandling;
            //    options.SerializerSettings.ContractResolver = settings.ContractResolver;
            //});
        }
    }
}
