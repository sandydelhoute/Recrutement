using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Recrutement.Dal.Entities;
using Recrutement.Dal.Interfaces;
using Recrutement.Dal.Mappers;
using Recrutement.Dal.Models;
using Recrutement.Dal.Repositories;

namespace Recrutement.Dal.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddSqlServerPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PokemonContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
        }
        public static void AddMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingDalToBllProfile),typeof(MappingBllToDalProfile));
        }
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Pokemon>, PokemonRepository>();
        }
    }
}
