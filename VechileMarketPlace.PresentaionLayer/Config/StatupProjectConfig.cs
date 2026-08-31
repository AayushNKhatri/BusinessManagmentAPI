//using BusinessManagment.DomainLayer.Configuration;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Design;

//namespace BusinessManagment.PresentaionLayer.Config
//{
//    public class StatupProjectConfig : IDesignTimeDbContextFactory<ApplicationDBContext>
//    {
//        public ApplicationDBContext CreateDbContext(string[] args)
//        {
//            IConfiguration config = new ConfigurationBuilder().SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "BusinessManagment.PresentaionLayer"))
//            .AddJsonFile("appsettings.json", optional: false).Build();
//            var builder = new DbContextOptionsBuilder<ApplicationDBContext>();
//            var connectionString = config.GetConnectionString("DefaultConnection");

//            builder.UseNpgsql(connectionString);

//            return new ApplicationDBContext(builder.Options);
//        }
//    }
//}
