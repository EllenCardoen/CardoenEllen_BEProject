using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BEProjectEllen.Core.Data;
using BEProjectEllen.Core.Repositories;
using BEProjectEllen.Core.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
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

            // TODO: IoC container vullen met nieuwe repo's 
            services.AddScoped<IQuizRepo, QuizRepo>();
            services.AddScoped<IUserChoiceRepo, UserChoiceRepo>();
            services.AddScoped<IChoiceRepo, ChoiceRepo>();
            services.AddScoped<IQuestionRepo, QuestionRepo>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();


            services.AddCors(options =>

                options.AddPolicy("MyAllowOrigins", builder =>
                {
                    builder.AllowAnyMethod()
                    .AllowAnyHeader()
                    .WithOrigins("https://localhost:44341", "http://localhost:1337", "http://localhost:8080", "https://localhost:44376", "https://localhost:44390")
                    .AllowCredentials();
                })
            );
            // TODO: Automapper implementeren (2dependencies)s
            services.AddAutoMapper(typeof(Startup));

            services.AddDbContext<QuizDBContext>(options => options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
               .AddRoles<IdentityRole>()
               .AddEntityFrameworkStores<QuizDBContext>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options => {
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = Configuration["Tokens:Issuer"],
                        ValidAudience = Configuration["Tokens:Audience"],



                        IssuerSigningKey = new SymmetricSecurityKey
                            (Encoding.UTF8.GetBytes(Configuration["Tokens:Key"]))
                    };
                    options.SaveToken = false;
                    options.RequireHttpsMetadata = false;
                });

            services.AddSwaggerGen(
               c =>
               {
                   c.SwaggerDoc("v1.0", new OpenApiInfo { Title = "API", Version = "v1.0" });
                 // Set the comments path for the Swagger JSON and UI. nodig voor xml te lezen
                 var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                   var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                   c.IncludeXmlComments(xmlPath);

                 // sets authorization
                 c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                   {
                       Name = "Authorization",
                       Type = SecuritySchemeType.ApiKey,
                       Scheme = "Bearer",
                       BearerFormat = "JWT",
                       In = ParameterLocation.Header,
                       Description = "JWT Authorization header using the Bearer scheme. Don't forgot Bearer {{bearertoken}}"
                   });

                   c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                  {
                        new OpenApiSecurityScheme
                          {
                              Reference = new OpenApiReference
                              {
                                  Type = ReferenceType.SecurityScheme,
                                  Id = "Bearer"
                              }
                          },
                          new string[] { "Bearer"}

                  }
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
            else
            {
                app.UseHsts();
            }

            app.UseCors(cfg =>
            {
                cfg.WithOrigins("https://localhost:5001")
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                .AllowCredentials();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = "swagger";
                c.SwaggerEndpoint("/swagger/v1.0/swagger.json", "aspnet-BEProjectEllen.Web v1.0");
            });

            app.UseHttpsRedirection();

            app.UseRouting();


            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); 
            });
        }
    }
}
