using EcommerceWebsite.CustomerSite.Services;
using EcommerceWebsite.CustomerSite.Services.APIs;
using EcommerceWebsite.CustomerSite.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebsite.CustomerSite
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
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = "Cookies";
                options.DefaultChallengeScheme = "oidc";
            })
                 .AddCookie("Cookies")
                 .AddOpenIdConnect("oidc", options =>
                 {
                     options.Authority = "https://localhost:44387";
                     options.RequireHttpsMetadata = false;
                     options.GetClaimsFromUserInfoEndpoint = true;

                     options.ClientId = "mvc";
                     options.ClientSecret = "secret";
                     options.ResponseType = "code";

                     options.SaveTokens = true;

                     options.Scope.Add("openid");
                     options.Scope.Add("profile");
                     options.Scope.Add("ecommercewebsite.api");

                     options.TokenValidationParameters = new TokenValidationParameters
                     {
                         NameClaimType = "name",
                         RoleClaimType = "role"
                     };
                 });

            services.AddHttpClient();
            services.AddTransient<IProductClient, ProductApiClient>();
            services.AddTransient<ICategoryClient, CategoryApiClient>();
            services.AddTransient<IRatingClient, RatingApiClient>();
            services.AddTransient<IOrderClient, OrderApiClient>();
            services.AddTransient<IRequest, Request>();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddControllersWithViews();

            //User sessions
            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            //Add UseAuthentication after config
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
