using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SoftUniCourseProject2024.Infrastructure.Data;

namespace SoftUniCourseProject2024.Extensions
{
    static class ServiceCollectionExtention
    {
        static public IServiceCollection AddApplicationServices(this IServiceCollection services)

        {
            return services;
        }


        static public IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)

        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        static public IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)

        {

            services
                .AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            return services;
        }
    }
}
