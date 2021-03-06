﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using ParkingLot.Core.Interface;
using ParkingLot.Infrastructure.Repository;
using ParkingLot.Infrastructure.Entity;
using Microsoft.EntityFrameworkCore;

namespace ParkingLot.Api
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            var connection = Configuration.GetConnectionString("SqlDb");

            services.AddDbContext<EntityDataPrueba>(option => option.
            UseSqlServer(connection, sqlServerOptionsAction: sqloptions => 
            { sqloptions.MigrationsAssembly("ParkingLot.Api");
            sqloptions.EnableRetryOnFailure(
                maxRetryCount: 5,
                maxRetryDelay: TimeSpan.FromSeconds(10),
                errorNumbersToAdd: null                    
                    );
            }).EnableSensitiveDataLogging());


            services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Info { Title = "Api ParkingLot", Version = "v1" });
});

            services.AddScoped<IUser, userRepository>();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            //using (var servicescope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            //{
            //    var context = servicescope.ServiceProvider.GetService<EntityDataPrueba>();
            //    context.Database.EnsureCreated();

            //}
            
            //if (env.IsDevelopment())
            //{
            app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //app.UseHsts();
            //}

            //app.UseHttpsRedirection();
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
           {
               c.SwaggerEndpoint("/swagger/v1/swagger.json", "NetCore API");
               c.RoutePrefix = string.Empty;
           });

        }
    }
}
