using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using BEProjectEllen.Core.Data;
using BEProjectEllen.Core.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace BEProjectEllen.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<IQuizRepo, QuizRepo>();
            services.AddScoped<IUserChoiceRepo, UserChoiceRepo>();


            services.AddCors(options =>

                options.AddPolicy("MyAllowOrigins", builder =>
                {
                    builder.AllowAnyMethod()
                    .AllowAnyHeader()
                    .WithOrigins("https://localhost:44341", "http://localhost:1337", "http://localhost:8080", "https://localhost:44376", "https://localhost:44390")
                    .AllowCredentials();
                })
            );


            services.AddDbContext<QuizDBContext>(options => options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1.0", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v1.0",
                    Title = "aspnet-BEProjectEllen.Web"
                });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(cfg =>
            {

                cfg.WithOrigins("https://localhost:44341", "https://localhost:44363", "http://localhost:1337", "http://localhost:8080", "https://localhost:44376", "https://localhost:44390")
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                .AllowCredentials();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = "swagger";
                //c.SwaggerEndpoint("/api/swagger/v1.0/swagger.json", "ProjectBE_api v1.0");
                c.SwaggerEndpoint("/swagger/v1.0/swagger.json", "aspnet-BEProjectEllen.Web v1.0");
            });

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
