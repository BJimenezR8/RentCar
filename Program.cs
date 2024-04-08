using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RentCar.Models;
using Microsoft.AspNetCore.Identity;
using RentCar.Data;
using RentCar.Areas.Identity.Data;

namespace RentCar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            builder.Services.AddDbContext<DbAa5e9fBryantj001Context>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("conexion")));

            builder.Services.AddDefaultIdentity<RentCarUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<RentCarContext>();


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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapRazorPages();

            app.Run();
        }
    }
}
