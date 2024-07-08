using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using MudBlazor.Services;

class Program
{

    static WebApplication WebApp;

    static int Main(string[] args)
    {
        try
        {

            var builder = WebApplication.CreateBuilder(args);

            StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

            // NLog: Setup NLog for Dependency injection
            builder.Logging.ClearProviders();

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();

            builder.Services.AddMudServices();

            WebApp = builder.Build();

            // Configure the HTTP request pipeline.
            if (!WebApp.Environment.IsDevelopment())
            {
                WebApp.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                WebApp.UseHsts();
            }

            WebApp.UseStaticFiles();

            WebApp.UseRouting();

            // WebApp.UseAuthentication();
            // WebApp.UseAuthorization();

            WebApp.MapBlazorHub();
            WebApp.MapFallbackToPage("/_Host");

            WebApp.Run();
            return 0;
        }
        catch (Exception ex)
        {
            return 1;
        }
        finally
        {
        }
    }

}
