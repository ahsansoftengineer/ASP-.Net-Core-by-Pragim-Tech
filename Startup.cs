using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Core_Demo_2
{
    public class Startup
    {
        private IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,
                              ILogger<Startup> logger)
        {
            // This is called as Pipeline
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.Use(async (context, next) =>
            {
                logger.LogInformation("MW 1: Incomming Request");
                await context.Response.WriteAsync("<p></p>Response from 1st Middleware </br> ");
                await next();
                await context.Response.WriteAsync("Response from 1st Middleware </br> ");
                logger.LogInformation("MW 1: OutGoing Response");
            });

            app.Use(async (context, next) =>
            {
                logger.LogInformation("MW 2: Incomming Request");
                await context.Response.WriteAsync("Response from 2nd Middleware </br> ");
                await next();
                await context.Response.WriteAsync("Response from 2nd Middleware </br> ");
                logger.LogInformation("MW 2: OutGoing Response");
            });

            app.Run(async (context) =>
            {
                logger.LogInformation("MW 3: Request Handled and Response Produce");
                await context.Response.WriteAsync("MW 3: Request Handled and Response Produce");
            });
        }
    }
}
