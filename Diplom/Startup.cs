using JWT.Infrastructure.Context;
using JWT.Infrastructure.UoW;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Shop.Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tinkoff.InvestApi;

namespace Diplom
{
    public class Startup
    {
        private readonly string _CorsPolicyName = "AllowAll";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddCors(options =>
            {
                options.AddPolicy(_CorsPolicyName,
                    builder =>
                    {
                        builder
                            .AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader();
                        //Я за то, чтобы выпилить в принципе CORS. Ибо к нам никто не стучится кроссдоменно
                        //.AllowCredentials();
                        //The CORS specification also states that setting origins to "*" (all origins) is invalid if the Access-Control-Allow-Credentials header is present.
                        //https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-2.2
                    });
            });
            services.Configure<Settings>(Configuration.GetSection(nameof(Settings)));
            services.AddDbContext<UserContext>(options => options.UseSqlServer(Configuration.GetSection(nameof(Settings)).GetValue<string>("ContextConnectionString")));
            // установка конфигурации подключения
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => //CookieAuthenticationOptions
                {
                    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
                    options.AccessDeniedPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
                });
            services.AddInvestApiClient((_, settings) => settings.AccessToken = "t.uysh4yKgQ4ynjw5-uwZ_r83u9Izwupa_k4Hglown62A3RtZ7wUjbb7jtFj7D0W7CSDqI7bSbatroA0gZob1ufg");
            services.AddScoped<UnitOfWork>();
            services.AddControllersWithViews();

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
                app.UseExceptionHandler("/Error");
            }
            app.UseHttpsRedirection();

            app.Use(async (ctx, next) =>
            {
                await next();

                if (ctx.Response.StatusCode == 404 && !ctx.Response.HasStarted)
                {
                    ctx.Request.Path = "/Home/PageNotFound";
                    await next();
                }
            });
            app.UseCors(_CorsPolicyName);
            app.UseStaticFiles(new StaticFileOptions
            {
                OnPrepareResponse = context =>
                {
                    if (!String.IsNullOrWhiteSpace(context.Context.Request.Query["v"].ToString()))
                    {
                        context.Context.Response.Headers.Add(
                            "cache-control",
                            new[] { "public,max-age=31536000" }); //1 год
                        context.Context.Response.Headers.Add("Expires",
                            new[] { DateTime.UtcNow.AddYears(1).ToString("R") }); //RFC1123 Совместимость с Html1.0
                    }
                },
            });
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Shares}/{id?}");
            });
        }
    }
}
