using BusinessLogic.Commands.TextCommands;
using BusinessLogic.Interfaces.Facades;
using BusinessLogic.Interfaces.Repositories;
using EfCommands.Commands.TextCommands;
using EfCommands.Commands.TextCommands.CountTextContentWords;
using EfCommands.Facades;
using EfCommands.Repositories;
using EfDataAccess;
using EfDataAccess.DbConnection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application1
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
            services.AddControllersWithViews();

            services.AddDbContext<AppDbContext>();
            services.AddTransient<IReadTextContentDb, CountTextContentWordsDb>();
            services.AddTransient<IReadTextContentFile, CountTextContentWordsFile>();
            services.AddTransient<IReadTextContentInput, CountTextContentWordsInput>();
            services.AddTransient<ITextRepository, TextRepository>();
            services.AddTransient<ICreateTextCommand, CreateTextCommand>();
            services.AddTransient<IGetAllTextsCommand, GetAllTextsCommand>();
            services.AddTransient<ITextFacade, TextFacade>();
            services.AddTransient<IDbConnection, SqlServerDbConnection>();
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
                app.UseExceptionHandler("/Text/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Text}/{action=Index}/{id?}");
            });
        }
    }
}
