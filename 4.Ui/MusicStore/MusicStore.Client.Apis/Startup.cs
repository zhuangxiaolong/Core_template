using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository.EF;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using MusicStore.Assemblers;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace MusicStore.Client.Apis
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
#if DEV
                .AddJsonFile("appsettings.dev.json", false, true)
#endif
#if UAT
                .AddJsonFile("appsettings.uat.json", false, true)
#endif
#if PROD
                .AddJsonFile("appsettings.prod.json", false, true) 
#endif
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public IContainer Container { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork>(e =>
            {
                //var config = e.GetRequiredService<Configuration>();
                var connection = @"Server=.\;Database=MusicStore;Trusted_Connection=True;MultipleActiveResultSets=true";
                return new MusicStoreContext(connection);
            });

            services.AddMvc();

            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new Info { Title = "Music Store API", Version = "v1" });
            //});

            services.RegistRepository();

            var builder = new ContainerBuilder();
            registServices(builder);
            builder.Populate(services);
            Container = builder.Build();
            return new AutofacServiceProvider(Container);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            //app.UseSwagger();
            //app.UseSwaggerUI(opt =>
            //{
            //    opt.SwaggerEndpoint("/swagger/v1/swagger.json", "Music Store API");
            //   // opt.RoutePrefix = string.Empty;
            //});
        }
        private void registServices(ContainerBuilder builder)
        {
            builder.RegisterInstance(Configuration);
            builder.RegistAssembler();
        }
    }
}
