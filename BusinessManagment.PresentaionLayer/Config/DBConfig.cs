using BusinessManagment.DomainLayer.Configuration;
using Microsoft.EntityFrameworkCore;

namespace BusinessManagment.PresentaionLayer.Config
{
    public static class DBConfig
    {
        //public static IServiceCollection AddDBConfig(this IServiceCollection services, IConfiguration config)
        //{
        //    services.AddDbContext<ApplicationDBContext>(opt => opt.UseNpgsql(config.GetConnectionString("DefaultConnection")));
        //    return services;
        //}
        public static void ApplyPendingMigrations(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            var services = scope.ServiceProvider;
            try
            {
                var context = services.GetRequiredService<ApplicationDBContext>();
                context.Database.Migrate();
            }
            catch (Exception ex)
            {
                var logger = services.GetRequiredService<ILogger<ApplicationDBContext>>();
                logger.LogError(ex, "An error occurred while migrating the database.");
            }
        }
    }
}
