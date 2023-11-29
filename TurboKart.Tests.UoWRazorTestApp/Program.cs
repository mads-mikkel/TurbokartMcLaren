using Microsoft.EntityFrameworkCore;

using TurboKart.Application.Interfaces;
using TurboKart.Application.UseCases;
using TurboKart.Infrastructure.Persistence.EfContexts;
using TurboKart.Infrastructure.Persistence.Interfaces;
using TurboKart.Infrastructure.Persistence.Repositories;

namespace TurboKart.Tests.UoWRazorTestApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            builder.Services.AddDbContext<DbContext, TurboKartContext>();
            builder.Services.AddTransient<IBookingRepository, BookingRepository>();
            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
            builder.Services.AddTransient<IBookingUseCase, BookingUseCase>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}