using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_Demo_2.Models;
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
            // Changes 1 for MVC
            services.AddMvc().AddXmlSerializerFormatters();
            // Here we r Registering the IEmployeeRepository to work with DI
            services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // This is called as Pipelines
            // Developer Exception Middle weare
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            // Changes 2 for MVC
            app.UseMvcWithDefaultRoute();
        }
    }
}
