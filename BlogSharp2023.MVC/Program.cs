using BlogSharp2023.APICLIENT;
using BlogSharp2023.DAL;
using BlogSharp2023.DAL.Memory;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace BlogSharp2023.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //add authentication using cookies
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
       .AddCookie();

            builder.Services.AddSingleton<IBlogPostDao, InMemoryBlogPostDao>();
            //builder.Services.AddSingleton<IAuthorDao, InMemoryAuthorDao>();
            builder.Services.AddSingleton<IAuthorDao>(new AuthorApiClient("https://localhost:7114/api/Authors"));


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}