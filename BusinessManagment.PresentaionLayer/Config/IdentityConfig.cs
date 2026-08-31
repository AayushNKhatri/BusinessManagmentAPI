using BusinessManagment.DomainLayer.Configuration;
using BusinessManagment.DomainLayer.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace BusinessManagment.PresentaionLayer.Config
{
    public static class IdentityConfig
    {
        public static IServiceCollection AddIdentityConfiguration(this IServiceCollection services)
        {
            services.AddIdentity<Users, IdentityRole>(opt =>
            {
                opt.Password.RequireDigit = true;
                opt.Password.RequiredLength = 8;
                opt.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<ApplicationDBContext>()
            .AddDefaultTokenProviders();
            return services;
        }
    }
}
