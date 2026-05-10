using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using WarpMe.Components;
using WarpMe.Data;
using WarpMe.Data.Models;
using WarpMe.Services;

namespace WarpMe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();
            builder.Services.AddMudServices();
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data Source=warpme.db"));
            // Register Class to get DbContext with injection
            builder.Services.AddScoped<ProfileService>();
            builder.Services.AddScoped<LinkService>();


            var app = builder.Build();

            // Seed Data
            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                if (!db.UserProfiles.Any())
                {
                    db.UserProfiles.Add(new UserProfile
                    {
                        Id = 1,
                        Username = "admin",
                        DisplayName = "Manuel",
                        Bio = "Meine Bio",

                    });


                    db.SaveChanges();
                }
            }

            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                if (!db.LinkItems.Any())
                {
                    db.LinkItems.Add(new LinkItem
                    {
                        Id = 1,
                        ProfileId = 1,
                        Title = "Instagram",
                        Url = "https://www.instagram.com",
                        Order = 1,
                        IsVisible = true,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    });
                }
                db.SaveChanges();
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
            app.UseHttpsRedirection();

            app.UseAntiforgery();

            app.MapStaticAssets();
            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
