using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Tavisca.Applause.Cassandra;

using Tavisca.Applause.Core;
using Tavisca.Applause.Core.Services;
using Tavisca.Applause.Web.Middleware;

namespace Tavisca.Applause.Web
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
            services.AddTransient<IEmployeeService,EmployeeService>();
            services.AddTransient<IAwardService, AwardService>();
            services.AddTransient<IConfigurationService, ConfigurationService>();
            services.AddTransient<IRulesService, RuleService>();
            services.AddSingleton<IAwardsRepository, MockAwardsStore>();
            services.AddSingleton<IBadgeRulesRepository, MockBadgeRulesStore>();
            services.AddSingleton<IEmployeeBadgeRepository, MockEmployeeBadgeRepository>();
            services.AddSingleton<IConfigurationRepository, MockConfigurationStore>();
            services.AddSingleton<IEmployeeRepository, MockEmployeesStore>();
            services.AddSingleton<IPlatformRuleRepository, MockPlatformRuleStore>();
            services.AddTransient<IGithubStatisticsService, GithubStatisticsService>();
            services.AddTransient<ITimeSheetStatisticsService, TimesheetStatisticsService>();
            services.AddSingleton<IGithubStatisticsRepository, MockGithubStatisticsStore>();
            services.AddSingleton<ITimesheetStatisticsRepository, MockTimeSheetStatsticsStore>();
            services.AddSingleton<IEmployeeActivityRepository, MockEmployeeActivityStore>();
            services.AddTransient<IEmployeeActivityService, EmployeeActivityService>();
           
            services.AddTransient<IBadgeService, BadgeService>();
            services.AddTransient<IEmployeeActivityService, EmployeeActivityService>();
            services.AddSingleton<IEmployeeActivityRepository, MockEmployeeActivityStore>();

            // add suppport for gzip and brotli
            services.AddResponseCompression(options =>
            {
                options.Providers.Add<BrotliCompressionProvider>();
                options.Providers.Add<GzipCompressionProvider>();
                options.MimeTypes =
                    ResponseCompressionDefaults.MimeTypes.Concat(
                        new[] { "image/svg+xml", "image/jpeg", "image/png" });
            });

            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
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
                app.UseExceptionHandler("/Error");
            }

            app.UseResponseCompression();
            app.UseMiddleware<ErrorHandler>();

            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }
    }
}
