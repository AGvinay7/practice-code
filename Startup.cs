using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.OpenApi.Models;
using sample_Web_API.AdapterDesignPattern.Impl;
using sample_Web_API.AdapterDesignPattern.Interface;
using sample_Web_API.Processors.Impl;
using sample_Web_API.Processors.Interface;
using sample_Web_API.SingleTon.Impl;
using sample_Web_API.SingleTon.Interface;
using Swashbuckle.AspNetCore.Swagger;


namespace sample_Web_API
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
            /*suppose if you have two Classes who have implemented IDesignPatterns
            then write two lines seperately like below
             services.TryAddTransient<IDesignPatterns, DesignPatterns_A>();
             services.TryAddTransient<IDesignPatterns, DesignPatterns_B>();
             services.TryAddTransient<IDesignPatterns, DesignPatterns_C>();    */
            services.TryAddTransient<IDesignPatterns, DesignPatterns>();
            services.TryAddSingleton<ISingletonProcessor, SingletonProcessor>();
            services.TryAddTransient<IAdapterDemo, AdapterClass>();


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);        
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Vinay's sample APIs", Version = "v1" });
            });            

        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();           
            app.UseSwagger(option => { option.RouteTemplate = "swagger/{documentName}/swagger.json"; });
            app.UseSwaggerUI(option =>
            {
                option.SwaggerEndpoint("v1/swagger.json", "Just code bro!");
            });
        }
    }
}
