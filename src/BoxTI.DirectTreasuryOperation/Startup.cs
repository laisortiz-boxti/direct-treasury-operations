using BoxTI.DirectTreasuryOperation.API.Configurations;
using BoxTI.DirectTreasuryOperation.API.Middlewares;
using BoxTI.DirectTreasuryOperation.Data;
using BoxTI.DirectTreasuryOperation.Data.Interfaces;
using BoxTI.DirectTreasuryOperation.Data.Repositories;
using BoxTI.DirectTreasuryOperation.Services;
using BoxTI.DirectTreasuryOperation.Services.OperationAmount;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace BoxTI.DirectTreasuryOperation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddCors();

            services.AddMvcConfiguration();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BoxTI.DirectTreasuryOperation", Version = "v1" });
            });

            //services.AddAutoMapper(typeof(Startup));
            services.AddAutoMapperConfiguration();

            //services.AddExceptionHandlingConfiguration();

            services.AddScoped<IDirectTreasuryRepository, DirectTreasuryRepository>();
            services.AddScoped<IDirectTreasuryOperationService, DirectTreasuryOperationService>();

            services.AddScoped<IOperationAmountRepository, OperationAmountRepository>();
            services.AddScoped<IOperationAmountService, OperationAmountService>();
            services.AddDbContext<DirectTreasuryContext>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware<ExceptionHandlerMiddleware>();

            using (var db = new DirectTreasuryContext())
            {
                db.Database.EnsureCreated();
            }

            app.UseCors(builder =>
            {
                builder.AllowAnyOrigin();
                builder.AllowAnyMethod();
                builder.AllowAnyHeader();
            });

            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BoxTI.DirectTreasuryOperation v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
