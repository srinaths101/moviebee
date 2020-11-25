using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Areas.Identity.Data;

[assembly: HostingStartup(typeof(MvcMovie.Areas.Identity.IdentityHostingStartup))]
namespace MvcMovie.Areas.Identity
{
  public class IdentityHostingStartup : IHostingStartup
  {
    public void Configure(IWebHostBuilder builder)
    {
      builder.ConfigureServices((context, services) =>
      {
        services.AddDbContext<MvcMovieIdentityDbContext>(options =>
            options.UseMySql(
                context.Configuration.GetConnectionString("MvcMovieIdentityDbContextConnection")));

        services.AddDefaultIdentity<ApplicationUser>(options =>
        {
          options.Password.RequireLowercase = false;
          options.Password.RequireUppercase = false;
          options.SignIn.RequireConfirmedAccount = false;
          options.Password.RequireDigit = false;
          options.Password.RequireNonAlphanumeric = false;
          options.Password.RequiredLength = 6;
        }).AddEntityFrameworkStores<MvcMovieIdentityDbContext>();
      });
    }
  }
}