using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Tourism.Model;
using Tourism.Persistence;
using Tourism.Persistence.Infastructure;
using Tourism.Service;
using Tourism.Service.Implementation;
using Tourism.Service.Interface;

namespace Tourism.Web
{
    public class Startup
    {
       // private readonly IConfigurationRoot _configRoot;
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        

        {
            Configuration = configuration;

           // IConfigurationBuilder builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
           // this._configRoot = builder.Build();

       }

       

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IRoleService, RoleService>();
             services.AddTransient<IUserRoleService,UserRoleService>();
           
            services.AddTransient<IPackageService, PackageService>();
            services.AddTransient<IPackageContentService, PackageContentService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<TourismContext>();
            services.AddTransient<IRepository<User>, Repository<User>>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
